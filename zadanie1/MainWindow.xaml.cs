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

namespace pz1_penkina
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
                double x = Convert.ToDouble(TextBox1.Text.ToString());
                double a;
                if (x > 0)
                {
                    a = ((3 * x * x) - (1 / x * x));
                }
                else
                {
                    a = (2 * Math.Sin(Math.Cos(4 * x)));
                }
                label2.Content = "f(x) = " + a;
            }
            catch
            {
                MessageBox.Show("Ошибка: Проверьте правильность введенных данных.                       " +
                    "Error: Check that the entered data is correct.");
            }

        }
    }
}
