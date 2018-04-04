using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAndFolderDialog.Wpf.Samples.ViewModels
{
    public class SelectFolderDialogExampleViewModel : NinjaMvvm.Wpf.WpfViewModelBase
    {
        private readonly Abstractions.IFolderDialogService _folderDialogService;
        public SelectFolderDialogExampleViewModel() { }//design time only
        public SelectFolderDialogExampleViewModel(FileAndFolderDialog.Abstractions.IFolderDialogService folderDialogService)
        {
            this._folderDialogService = folderDialogService;

            //set defaults
            var options = new FileAndFolderDialog.Abstractions.SelectFolderOptions();

            this.Description = options.Description;
            this.ShowNewFolderButton = options.ShowNewFolderButton;
            this.SelectedPath = options.SelectedPath;
            this.RootFolder = options.RootFolder;
        }

        public bool ShowNewFolderButton
        {
            get { return GetField<bool>(); }
            set { SetField(value); }
        }

        public string SelectedPath
        {
            get { return GetField<string>(); }
            set { SetField(value); }
        }

        public string Description
        {
            get { return GetField<string>(); }
            set { SetField(value); }
        }

        public Environment.SpecialFolder RootFolder
        {
            get { return GetField<Environment.SpecialFolder>(); }
            set { SetField(value); }
        }

        public string Result
        {
            get { return GetField<string>(); }
            set { SetField(value); }
        }

        #region ChooseFolder Command

        private NinjaMvvm.Wpf.RelayCommand _chooseFolderCommand;
        public NinjaMvvm.Wpf.RelayCommand ChooseFolderCommand
        {
            get
            {
                if (_chooseFolderCommand == null)
                    _chooseFolderCommand = new NinjaMvvm.Wpf.RelayCommand((param) => this.ChooseFolder(), (param) => this.CanChooseFolder());
                return _chooseFolderCommand;
            }
        }

        public bool CanChooseFolder()
        {
            return true;
        }

        /// <summary>
        /// Executes the ChooseFile command 
        /// </summary>
        public void ChooseFolder()
        {
            try
            {
                var options = new FileAndFolderDialog.Abstractions.SelectFolderOptions()
                {
                    Description = this.Description,
                    ShowNewFolderButton = this.ShowNewFolderButton,
                    SelectedPath = this.SelectedPath,
                    RootFolder = this.RootFolder,
                };

                var result = _folderDialogService.ShowSelectFolderDialog(options);
                if (string.IsNullOrEmpty(result))
                    this.Result = null;

                else
                    this.Result = result;
            }
            catch (Exception ex)
            {
                this.Result = ex.Message;
            }
        }

        #endregion

    }
}
