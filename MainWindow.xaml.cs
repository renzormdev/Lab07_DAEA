using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Demo07
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private InvoiceBusiness invoiceBusiness = new InvoiceBusiness();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListarButton_Click(object sender, RoutedEventArgs e)
        {
            LoadInvoices();
        }

        private void LoadInvoices()
        {
            InvoicesDataGrid.ItemsSource = invoiceBusiness.GetAllInvoices();
        }
    }
}