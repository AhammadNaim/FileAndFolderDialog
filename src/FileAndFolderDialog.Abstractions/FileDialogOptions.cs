using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAndFolderDialog.Abstractions
{
    public abstract class FileDialogOptions
    {
        ///<summary>
        ///     Gets the custom places collection for this Dialog instance.
        /// Returns:
        ///     The custom places collection for this Dialog instance.
        ///</summary>
        public Collection<string> CustomPlaces { get; } = new Collection<string>();

        ///<summary>
        ///     Gets or sets a value indicating whether the dialog box accepts only valid Win32
        ///     file names.
        /// Returns:
        ///     true if the dialog box accepts only valid Win32 file names; otherwise, false.
        ///     The default value is true.
        ///</summary>
        public bool ValidateNames { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating the Default name of the file that should be selected
        /// </summary>
        public string DefaultFileName { get; set; }

        ///<summary>
        ///     Gets or sets the file dialog box title.
        /// Returns:
        ///     The file dialog box title. The default value is an empty string ("").
        ///</summary>
        public string Title { get; set; } = "";

        ///<summary>
        ///     Gets or sets a value indicating whether the dialog box restores the directory
        ///     to the previously selected directory before closing.
        /// Returns:
        ///     true if the dialog box restores the current directory to the previously selected
        ///     directory if the user changed the directory while searching for files; otherwise,
        ///     false. The default value is false.
        ///</summary>
        public bool RestoreDirectory { get; set; }

        ///<summary>
        ///     Gets or sets the initial directory displayed by the file dialog box.
        /// Returns:
        ///     The initial directory displayed by the file dialog box. The default is an empty
        ///     string ("").
        ///</summary>
        public string InitialDirectory { get; set; } = "";
        //
        ///<summary>
        ///     Gets or sets the index of the filter currently selected in the file dialog box.
        //
        /// Returns:
        ///     A value containing the index of the filter currently selected in the file dialog
        ///     box. The default value is 1.
        ///</summary>
        public int FilterIndex { get; set; } = 1;

        ///<summary>
        ///     Gets or sets the current file name filter string, which determines the choices
        ///     that appear in the "Save as file type" or "Files of type" box in the dialog box.
        /// Returns:
        ///     The file filtering options available in the dialog box.
        /// Exceptions:
        ///   T:System.ArgumentException:
        ///     Filter format is invalid.
        ///</summary>
        public string Filter { get; set; }

        ///<summary>
        ///     Gets or sets a value indicating whether the dialog box returns the location of
        ///     the file referenced by the shortcut or whether it returns the location of the
        ///     shortcut (.lnk).
        /// Returns:
        ///     true if the dialog box returns the location of the file referenced by the shortcut;
        ///     otherwise, false. The default value is true.
        ///</summary>
        public bool DereferenceLinks { get; set; } = true;

        ///<summary>
        ///     Gets or sets the default file name extension.
        /// Returns:
        ///     The default file name extension. The returned string does not include the period.
        ///     The default value is an empty string ("").
        ///</summary>
        public string DefaultExt { get; set; } = "";

        ///<summary>
        ///     Gets or sets a value indicating whether the dialog box displays a warning if
        ///     the user specifies a path that does not exist.
        /// Returns:
        ///     true if the dialog box displays a warning when the user specifies a path that
        ///     does not exist; otherwise, false. The default value is true.
        ///</summary>
        public bool CheckPathExists { get; set; } = true;
        //
        ///<summary>
        ///     Gets or sets a value indicating whether the dialog box displays a warning if
        ///     the user specifies a file name that does not exist.
        /// Returns:
        ///     true if the dialog box displays a warning if the user specifies a file name that
        ///     does not exist; otherwise, false. The default value is false.
        ///</summary>
        public virtual bool CheckFileExists { get; set; }

        ///<summary>
        ///     Gets or sets a value indicating whether the dialog box automatically adds an
        ///     extension to a file name if the user omits the extension.
        /// Returns:
        ///     true if the dialog box adds an extension to a file name if the user omits the
        ///     extension; otherwise, false. The default value is true.
        ///</summary>
        public bool AddExtension { get; set; } = true;
    }
}
