using Dan_LVI_Kristina_Garcia_Francisco.ViewModel;
using System.Threading.Tasks;
using System.Windows;

namespace Dan_LVI_Kristina_Garcia_Francisco
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Main window
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel(this);
        }
    }
}
