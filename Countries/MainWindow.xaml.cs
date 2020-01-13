using System.Windows;

namespace Countries
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new VM();
        }

        private void ComboBox_Selected(object sender, RoutedEventArgs e)
        {
            COUNTRY c = (COUNTRY)CB.SelectedItem;
            MessageBox.Show(c.CapitalCity);
        }
    }
}
