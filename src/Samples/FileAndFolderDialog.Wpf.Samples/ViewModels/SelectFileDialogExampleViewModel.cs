using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAndFolderDialog.Wpf.Samples.ViewModels
{
    public class SelectFileDialogExampleViewModel : NinjaMvvm.Wpf.WpfViewModelBase
    {
        private readonly Abstractions.IFileDialogService _fileDialogService;
        public SelectFileDialogExampleViewModel() { }//design time only
        public SelectFileDialogExampleViewModel(FileAndFolderDialog.Abstractions.IFileDialogService fileDialogService)
        {
            this._fileDialogService = fileDialogService;

            //set defaults
            var options = new FileAndFolderDialog.Abstractions.OpenFileOptions();

            this.AddExtension = options.AddExtension;
            this.CheckFileExists = options.CheckFileExists;
            this.CheckPathExists = options.CheckPathExists;
            this.DefaultExt = options.DefaultExt;
            this.DereferenceLinks = options.DereferenceLinks;
            this.Filter = options.Filter;
            this.FilterIndex = options.FilterIndex;
            this.InitialDirectory = options.InitialDirectory;
            this.Multiselect = options.Multiselect;
            this.ReadOnlyChecked = options.ReadOnlyChecked;
            this.RestoreDirectory = options.RestoreDirectory;
            this.ShowReadOnly = options.ShowReadOnly;
            this.Title = options.Title;
            this.ValidateNames = options.ValidateNames;

            this.CustomPlaces = new ObservableCollection<string>();
        }

        public bool Multiselect
        {
            get { return GetField<bool>(); }
            set { SetField(value); }
        }
        public bool ReadOnlyChecked
        {
            get { return GetField<bool>(); }
            set { SetField(value); }
        }
        public bool ShowReadOnly
        {
            get { return GetField<bool>(); }
            set { SetField(value); }
        }
        public ObservableCollection<string> CustomPlaces
        {
            get { return GetField<ObservableCollection<string>>(); }
            set { SetField(value); }
        }
        public bool ValidateNames
        {
            get { return GetField<bool>(); }
            set { SetField(value); }
        }
        public string Title
        {
            get { return GetField<string>(); }
            set { SetField(value); }
        }
        public bool RestoreDirectory
        {
            get { return GetField<bool>(); }
            set { SetField(value); }
        }
        public string InitialDirectory
        {
            get { return GetField<string>(); }
            set { SetField(value); }
        }
        public int FilterIndex
        {
            get { return GetField<int>(); }
            set { SetField(value); }
        }
        public string Filter
        {
            get { return GetField<string>(); }
            set { SetField(value); }
        }
        public bool DereferenceLinks
        {
            get { return GetField<bool>(); }
            set { SetField(value); }
        }
        public string DefaultExt
        {
            get { return GetField<string>(); }
            set { SetField(value); }
        }
        public bool CheckPathExists
        {
            get { return GetField<bool>(); }
            set { SetField(value); }
        }
        public bool CheckFileExists
        {
            get { return GetField<bool>(); }
            set { SetField(value); }
        }
        public bool AddExtension
        {
            get { return GetField<bool>(); }
            set { SetField(value); }
        }



        public string SelectionResults
        {
            get { return GetField<string>(); }
            set { SetField(value); }
        }

        #region ChooseFile Command

        private NinjaMvvm.Wpf.RelayCommand _chooseFileCommand;
        public NinjaMvvm.Wpf.RelayCommand ChooseFileCommand
        {
            get
            {
                if (_chooseFileCommand == null)
                    _chooseFileCommand = new NinjaMvvm.Wpf.RelayCommand((param) => this.ChooseFile(), (param) => this.CanChooseFile());
                return _chooseFileCommand;
            }
        }

        public bool CanChooseFile()
        {
            return true;
        }

        /// <summary>
        /// Executes the ChooseFile command 
        /// </summary>
        public void ChooseFile()
        {
            try
            {
                var options = new FileAndFolderDialog.Abstractions.OpenFileOptions()
                {
                    AddExtension = this.AddExtension,
                    CheckFileExists = this.CheckFileExists,
                    CheckPathExists = this.CheckPathExists,
                    DefaultExt = this.DefaultExt,
                    DereferenceLinks = this.DereferenceLinks,
                    Filter = this.Filter,
                    FilterIndex = this.FilterIndex,
                    InitialDirectory = this.InitialDirectory,
                    Multiselect = this.Multiselect,
                    ReadOnlyChecked = this.ReadOnlyChecked,
                    RestoreDirectory = this.RestoreDirectory,
                    ShowReadOnly = this.ShowReadOnly,
                    Title = this.Title,
                    ValidateNames = this.ValidateNames,
                };

                this.CustomPlaces
                    .ToList()
                    .ForEach(p => options.CustomPlaces.Add(p));

                var results = _fileDialogService.ShowSelectFileDialog(options);
                if (results == null || !results.Any())
                    this.SelectionResults = null;

                else
                    this.SelectionResults = string.Join(Environment.NewLine, results);
            }
            catch (Exception ex)
            {
                this.SelectionResults = ex.Message;
            }
        }

        #endregion

    }
}
