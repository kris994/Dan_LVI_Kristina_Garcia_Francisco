using System.IO;
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

        /// <summary>
        /// Zips the file
        /// </summary>
        /// <param name="zipLocation">zip file location</param>
        /// <param name="folderLocation">folder location</param>
        public void ZIPAFile(string folderLocation, string zipLocation)
        {
            if (File.Exists(zipLocation + @"\ZIPFolder.zip"))
            {
                File.Delete(zipLocation + @"\ZIPFolder.zip");
            }

            // Create Folder if it does not exist
            Directory.CreateDirectory(folderLocation);
            Directory.CreateDirectory(zipLocation);

            ZipFile.CreateFromDirectory(folderLocation, zipLocation + @"\ZIPFolder.zip", CompressionLevel.Fastest, true);
        }
    }
}
