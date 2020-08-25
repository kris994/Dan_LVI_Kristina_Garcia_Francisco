using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace Dan_LVI_Kristina_Garcia_Francisco.Model
{
    /// <summary>
    /// Class that works with html files
    /// </summary>
    class HTMLClass
    {
        /// <summary>
        /// Gets thehtml file from the website
        /// </summary>
        /// <param name="urlAddress">the site address</param>
        /// <param name="folderLocation">folder location</param>
        public string GetHTMLFromURL(string folderLocation, string urlAddress)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    string htmlCode = client.DownloadString(urlAddress);
                    // Get the website title to use it as file name
                    string title = Regex.Match(htmlCode, @"\<title\b[^>]*\>\s*(?<Title>[\s\S]*?)\</title\>",
                        RegexOptions.IgnoreCase).Groups["Title"].Value;

                    WriteHTMLToFile(folderLocation, htmlCode, title);
                    return htmlCode;
                }
            }
            catch (WebException)
            {
                return null;
            }
        }

        /// <summary>
        /// Writes the html to file
        /// </summary>
        /// <param name="html">the html we are writing</param>
        /// <param name="htmlTitle">title of the html file</param>
        /// <param name="folderLocation">folder location</param>
        public void WriteHTMLToFile(string folderLocation, string html, string htmlTitle)
        {
            // Create Folder if it does not exist
            Directory.CreateDirectory(folderLocation);

            // Replace invalid path characters with _
            char[] invalidFileChars = Path.GetInvalidFileNameChars();
            foreach (char c in invalidFileChars)
            {
                htmlTitle = htmlTitle.Replace(c.ToString(), "_");
            }

            using (StreamWriter sw = new StreamWriter(folderLocation + @"\" + htmlTitle + ".html"))
            {
                sw.WriteLine(html);
            }
        }
    }
}
