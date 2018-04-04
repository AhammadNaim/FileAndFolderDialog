using System;
using System.Collections.Generic;
using System.Text;

namespace FileAndFolderDialog.Abstractions
{
    public class OpenFileOptions : FileDialogOptions
    {
        ///<summary>
        ///     Gets or sets a value indicating whether the dialog box displays a warning if
        ///     the user specifies a file name that does not exist.
        /// Returns:
        ///     true if the dialog box displays a warning when the user specifies a file name
        ///     that does not exist; otherwise, false. The default value is true.
        ///</summary>
        public override bool CheckFileExists { get; set; } = true;

        ///<summary>
        ///     Gets or sets a value indicating whether the dialog box allows multiple files
        ///     to be selected.
        /// Returns:
        ///     true if the dialog box allows multiple files to be selected together or concurrently;
        ///     otherwise, false. The default value is false.
        ///</summary>
        public bool Multiselect { get; set; }

        ///<summary>
        ///     Gets or sets a value indicating whether the read-only check box is selected.
        /// Returns:
        ///     true if the read-only check box is selected; otherwise, false. The default value
        ///     is false.
        ///</summary>
        public bool ReadOnlyChecked { get; set; }

        ///<summary>
        ///     Gets or sets a value indicating whether the dialog box contains a read-only check
        ///     box.
        /// Returns:
        ///     true if the dialog box contains a read-only check box; otherwise, false. The
        ///     default value is false.
        ///</summary>
        public bool ShowReadOnly { get; set; }

    }
}
