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

namespace CounterTotalSum_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private decimal totalPrice = 0;
        public MainWindow()
        {
            InitializeComponent();
            totalPriceTextBox.Text = totalPrice.ToString();
        }

        private void countButton_Click(object sender, RoutedEventArgs e)
        {
            if(decimal.TryParse(purchasePriceTextBox.Text, out decimal price))
            {
                totalPrice += price;
                totalPriceTextBox.Text = totalPrice.ToString();
            }
            else
            {
                MessageBox.Show("Введите корректные данные!");
            }
        }
    }
}