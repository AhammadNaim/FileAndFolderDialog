using System;
using System.Collections.Generic;
using System.Text;

namespace FileAndFolderDialog.Abstractions
{
    public class SelectFolderOptions
    {
        /// <summary>
        /// Gets or sets a value indicating whether the New Folder button appears in the folder browser dialog box.
        /// Returns: 
        ///     true if the New Folder button is shown in the dialog box; otherwise, false. The
        ///     default is true.
        /// </summary>
        public bool ShowNewFolderButton { get; set; }

        /// <summary>
        /// Gets or sets the path selected by the user.
        /// Returns:
        ///     The path of the folder first selected in the dialog box or the last folder selected
        ///     by the user. The default is an empty string ("").
        /// </summary>
        public string SelectedPath { get; set; }

        /// <summary>
        /// Gets or sets the descriptive text displayed above the tree view control in the dialog box.
        /// Returns:
        ///     The description to display. The default is an empty string ("").
        /// </summary>
        public string Description { get; set; }

        ///<summary>
        ///     Gets or sets the root folder where the browsing starts from.
        /// Returns:
        ///     One of the System.Environment.SpecialFolder values. The default is Desktop.
        /// Exceptions:
        ///   T:System.ComponentModel.InvalidEnumArgumentException:
        ///     The value assigned is not one of the System.Environment.SpecialFolder values.
        ///</summary>
        public Environment.SpecialFolder RootFolder { get; set; }
    }
}
