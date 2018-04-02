using System;
using System.Collections.Generic;
using System.Text;

namespace FileAndFolderDialog.Abstractions
{
    public class SaveFileOptions : FileDialogOptions
    {

        //
        // Summary:
        //     Gets or sets a value indicating whether Dialog prompts
        //     the user for permission to create a file if the user specifies a file that does
        //     not exist.
        //
        // Returns:
        //     true if dialog should prompt prior to saving to a filename that did not previously
        //     exist; otherwise, false. The default is false.
        public bool CreatePrompt { get; set; }
        //
        // Summary:
        //     Gets or sets a value indicating whether Dialog displays
        //     a warning if the user specifies the name of a file that already exists.
        //
        // Returns:
        //     true if dialog should prompt prior to saving over a filename that previously
        //     existed; otherwise, false. The default is true.
        public bool OverwritePrompt { get; set; }
    }
}
