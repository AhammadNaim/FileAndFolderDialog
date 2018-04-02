using System;
using System.Collections.Generic;
using System.Text;

namespace FileAndFolderDialog.Abstractions
{
    public class OpenFileOptions : FileDialogOptions
    {
        //
        // Summary:
        //     Gets or sets a value indicating whether the dialog box displays a warning if
        //     the user specifies a file name that does not exist.
        //
        // Returns:
        //     true if the dialog box displays a warning when the user specifies a file name
        //     that does not exist; otherwise, false. The default value is true.
        public override bool CheckFileExists { get; set; } = true;
        //
        // Summary:
        //     Gets or sets a value indicating whether the dialog box allows multiple files
        //     to be selected.
        //
        // Returns:
        //     true if the dialog box allows multiple files to be selected together or concurrently;
        //     otherwise, false. The default value is false.
        public bool Multiselect { get; set; }
        //
        // Summary:
        //     Gets or sets a value indicating whether the read-only check box is selected.
        //
        // Returns:
        //     true if the read-only check box is selected; otherwise, false. The default value
        //     is false.
        public bool ReadOnlyChecked { get; set; }
        //
        // Summary:
        //     Gets or sets a value indicating whether the dialog box contains a read-only check
        //     box.
        //
        // Returns:
        //     true if the dialog box contains a read-only check box; otherwise, false. The
        //     default value is false.
        public bool ShowReadOnly { get; set; }

    }
}
