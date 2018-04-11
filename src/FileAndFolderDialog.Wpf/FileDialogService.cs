using FileAndFolderDialog.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAndFolderDialog.Wpf
{
    public class FileDialogService : Abstractions.IFileDialogService
    {
        public IEnumerable<string> ShowSelectFileDialog(OpenFileOptions options = null)
        {
            if (options == null)
                options = new OpenFileOptions();

            var openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Multiselect = options.Multiselect;
            openFileDialog.AddExtension = options.AddExtension;
            openFileDialog.CheckFileExists = options.CheckFileExists;
            openFileDialog.CheckPathExists = options.CheckPathExists;
            openFileDialog.DefaultExt = options.DefaultExt;
            openFileDialog.DereferenceLinks = options.DereferenceLinks;
            openFileDialog.Filter = options.Filter;
            openFileDialog.FilterIndex = options.FilterIndex;
            openFileDialog.InitialDirectory = options.InitialDirectory;
            openFileDialog.ReadOnlyChecked = options.ReadOnlyChecked;
            openFileDialog.RestoreDirectory = options.RestoreDirectory;
            openFileDialog.ShowReadOnly = options.ShowReadOnly;
            openFileDialog.Title = options.Title;
            openFileDialog.ValidateNames = options.ValidateNames;
            openFileDialog.FileName = options.DefaultFileName;
            openFileDialog.CustomPlaces = options.CustomPlaces?
                .Select(path => new Microsoft.Win32.FileDialogCustomPlace(path))
                .ToList();

            var result = openFileDialog.ShowDialog();

            if (result == true)
                return openFileDialog.FileNames.ToList();
            else
                return null;
        }

        public string ShowSaveFileDialog(SaveFileOptions options = null)
        {
            if (options == null)
                options = new SaveFileOptions();

            var saveFileDialog = new Microsoft.Win32.SaveFileDialog();
            saveFileDialog.AddExtension = options.AddExtension;
            saveFileDialog.CheckFileExists = options.CheckFileExists;
            saveFileDialog.CheckPathExists = options.CheckPathExists;
            saveFileDialog.DefaultExt = options.DefaultExt;
            saveFileDialog.DereferenceLinks = options.DereferenceLinks;
            saveFileDialog.Filter = options.Filter;
            saveFileDialog.FilterIndex = options.FilterIndex;
            saveFileDialog.InitialDirectory = options.InitialDirectory;
            saveFileDialog.RestoreDirectory = options.RestoreDirectory;
            saveFileDialog.Title = options.Title;
            saveFileDialog.ValidateNames = options.ValidateNames;
            saveFileDialog.FileName = options.DefaultFileName;

            saveFileDialog.CustomPlaces = options.CustomPlaces?
                .Select(path => new Microsoft.Win32.FileDialogCustomPlace(path))
                .ToList();

            var result = saveFileDialog.ShowDialog();

            if (result == true)
                return saveFileDialog.FileName;
            else
                return null;
        }
    }
}
