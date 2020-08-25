using System.IO;
using System.Linq;
using System.IO.Compression;
using System.Collections.Generic;

namespace Dan_LVI_Kristina_Garcia_Francisco.Model
{
    /// <summary>
    /// Zips folders and files
    /// </summary>
    class ZIPClass
    {
        /// <summary>
        /// Checks if there are any files within the folder
        /// </summary>
        /// <param name="folderLocation">Location of the folder</param>
        /// <returns>true if there are no files in the folder</returns>
        public IEnumerable<string> IsDirectoryEmpty(string folderLocation)
        {
            // Create Folder if it does not exist
            Directory.CreateDirectory(folderLocation);

            return Directory.EnumerateFileSystemEntries(folderLocation);
        }

        public void ZIPAFile(string zipLocation, string folderLocation)
        {
            if (File.Exists(zipLocation))
            {
                File.Delete(zipLocation);
            }

            // Create Folder if it does not exist
            Directory.CreateDirectory(folderLocation);
            Directory.CreateDirectory(zipLocation);

            ZipFile.CreateFromDirectory(folderLocation, zipLocation, CompressionLevel.Fastest, true);
        }
    }
}
