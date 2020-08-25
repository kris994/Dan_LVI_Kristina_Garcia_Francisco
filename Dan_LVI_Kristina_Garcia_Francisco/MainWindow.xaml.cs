using Dan_LVI_Kristina_Garcia_Francisco.ViewModel;
using System.Windows;

namespace Dan_LVI_Kristina_Garcia_Francisco
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel(this);
        }
    }
}
