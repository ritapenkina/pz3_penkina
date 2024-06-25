using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pz2_penkina
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                int x = Convert.ToInt32(TextBox1.Text.ToString());
                int y = Convert.ToInt32(TextBox2.Text.ToString());
                int z = Convert.ToInt32(TextBox3.Text.ToString());
                int sum = x + y + z;
                int prod = x * y * z;
                if (sum > prod)
                {
                    label4.Content = "Максимальное значение, сумма, равна " + sum;
                }
                if (sum < prod)
                {
                    label4.Content = "Максимальное значение, произведение, равна " + prod;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка: Проверьте правильность введенных данных.                       " +
        "Error: Check that the entered data is correct.");
            }

        }
    }
}
