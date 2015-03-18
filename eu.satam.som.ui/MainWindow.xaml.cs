using MahApps.Metro.Controls;

namespace eu.satam.som.ui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private readonly MainViewModel mainViewModel;
        public MainWindow()
        {
            InitializeComponent();
            mainViewModel = new MainViewModel(this);
            this.DataContext = mainViewModel;
        }
    }
}
