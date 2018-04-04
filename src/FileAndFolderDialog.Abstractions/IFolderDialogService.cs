using System;
using System.Collections.Generic;
using System.Text;

namespace FileAndFolderDialog.Abstractions
{
    public interface IFolderDialogService
    {
        /// <summary>
        /// Displays a common dialog box that allows a user to select a folder
        /// </summary>
        /// <param name="options"></param>
        /// <returns>The selected folder location, or null if cancelled</returns>
        string ShowSelectFolderDialog(SelectFolderOptions options = null);
    }
}
