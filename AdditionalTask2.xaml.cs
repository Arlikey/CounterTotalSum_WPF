using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CounterTotalSum_WPF
{
    /// <summary>
    /// Interaction logic for AdditionalTask2.xaml
    /// </summary>
    public partial class AdditionalTask2 : Window
    {
        private string[] colors = { "Navy", "Blue", "Aqua", "Teal", "Olive", "Green", "Lime", "Yellow", "Orange",
        "Red", "Maroon", "Fuchsia", "Purple", "Black", "Silver", "Gray", "White" };
        public AdditionalTask2()
        {
            InitializeComponent();

            for (int i = 0; i < colors.Length; i++)
            {
                Button button = new Button();
                button.Content = colors[i];
                button.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colors[i]));
                button.Margin = new Thickness(2.0);
                wrapPanel.Children.Add(button);
            }
        }
    }
}
