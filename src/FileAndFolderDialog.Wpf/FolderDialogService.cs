using FileAndFolderDialog.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAndFolderDialog.Wpf
{
    public class FolderDialogService : Abstractions.IFolderDialogService
    {
        public string ShowSelectFolderDialog(SelectFolderOptions options = null)
        {
            if (options == null)
                options = new SelectFolderOptions();

            var folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = options.ShowNewFolderButton;
            folderBrowserDialog.SelectedPath = options.SelectedPath;
            folderBrowserDialog.Description = options.Description;
            folderBrowserDialog.RootFolder = options.RootFolder;

            var result = folderBrowserDialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
                return folderBrowserDialog.SelectedPath;
            else
                return null;
        }

    }
}
