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

namespace pz3_penkina
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
                Random random = new Random();
                int randomNum = random.Next(1, 26);
                if (randomNum == 1 || randomNum == 2 || randomNum == 3 || randomNum == 25)
                {
                    label1.Content = "Номер ряда " + randomNum;
                    label2.Content = "Цена билета 10 рублей";
                }
                if (randomNum == 4 || randomNum == 5)
                {
                    label1.Content = "Номер ряда " + randomNum;
                    label2.Content = "Цена билета 15 рублей";
                }
                else
                {
                    {
                        label1.Content = "Номер ряда " + randomNum;
                        label2.Content = "Цена билета 20 рублей";
                    }
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
