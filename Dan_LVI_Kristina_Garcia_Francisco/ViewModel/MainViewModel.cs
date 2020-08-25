using Dan_LVI_Kristina_Garcia_Francisco.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Dan_LVI_Kristina_Garcia_Francisco.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        readonly MainWindow mainWindow;

        #region Constructor
        /// <summary>
        /// Main View Consructor
        /// </summary>
        /// <param name="mainOpen">the mainv iew window</param>
        public MainViewModel(MainWindow mainOpen)
        {
            mainWindow = mainOpen;
        }
        #endregion

        #region Property
        private string hTMLPath;
        public string HTMLPath
        {
            get
            {
                return hTMLPath;
            }
            set
            {
                hTMLPath = value;
                OnPropertyChanged("HTMLPath");
            }
        }
        #endregion

        #region Commands
        /// <summary>
        /// Download HTML button
        /// </summary>
        private ICommand downloadHTML;
        public ICommand DownloadHTML
        {
            get
            {
                if (downloadHTML == null)
                {
                    downloadHTML = new RelayCommand(param => DownloadHTMLExecute(), param => CanDownloadHTMLExecute());
                }
                return downloadHTML;
            }
        }

        /// <summary>
        /// Method for downloading html
        /// </summary>
        public void DownloadHTMLExecute()
        {
            try
            {

            }
            catch (Exception)
            {
                MessageBoxResult dialog = Xceed.Wpf.Toolkit.MessageBox.Show("Currently the html downloader is unavaiable...", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Checks if its possible to press the download button
        /// </summary>
        /// <returns></returns>
        public bool CanDownloadHTMLExecute()
        {
            if (HTMLPath == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Zip files button
        /// </summary>
        private ICommand zIPFiles;
        public ICommand ZIPFiles
        {
            get
            {
                if (zIPFiles == null)
                {
                    zIPFiles = new RelayCommand(param => ZIPFilesExecute(), param => CanZIPFilesExecute());
                }
                return zIPFiles;
            }
        }

        /// <summary>
        /// Executes the zip files method
        /// </summary>
        public void ZIPFilesExecute()
        {

        }

        /// <summary>
        /// Checks if it is possible to press the zip files button
        /// </summary>
        public bool CanZIPFilesExecute()
        {
            return true;
        }

        /// <summary>
        /// Exit button
        /// </summary>
        private ICommand exit;
        public ICommand Exit
        {
            get
            {
                if (exit == null)
                {
                    exit = new RelayCommand(param => ExitExecute(), param => CanExitExecute());
                }
                return exit;
            }
        }

        /// <summary>
        /// Exits the current window
        /// </summary>
        private void ExitExecute()
        {
            MessageBoxResult dialog = Xceed.Wpf.Toolkit.MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (dialog == MessageBoxResult.Yes)
            {
                mainWindow.Close();
            }
        }

        /// <summary>
        /// Checks if its possible to press the button
        /// </summary>
        /// <returns></returns>
        private bool CanExitExecute()
        {
            return true;
        }
        #endregion
    }
}
