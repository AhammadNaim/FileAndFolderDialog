using System;
using System.Collections.Generic;
using System.Text;

namespace FileAndFolderDialog.Abstractions
{
    public interface IFileDialogService
    {
        /// <summary>
        /// Displays a common dialog box that allows a user to specify a filename for one or more files to select
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        IEnumerable<string> ShowSelectFileDialog(OpenFileOptions options = null);

        /// <summary>
        /// Displays a common dialog that allows the user to specify a filename to save a file as. 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        string ShowSaveFileDialog(SaveFileOptions options = null);
    }
}
