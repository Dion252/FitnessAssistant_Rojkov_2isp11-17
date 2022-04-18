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
using System.Windows.Navigation;
using System.Windows.Shapes;
using FitnessAssistant_Rojkov_2isp11_17.DataClass;
using FitnessAssistant_Rojkov_2isp11_17.DataBase;
using FitnessAssistant_Rojkov_2isp11_17.Windows;

namespace FitnessAssistant_Rojkov_2isp11_17
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

        private void BtnEnterAuth_Click(object sender, RoutedEventArgs e)
        {
            var item = AppData.Context.User.ToList().
           Where(i => i.Login == TbLogin.Text && i.Password == TbPassword.Text).FirstOrDefault();
            if (item != null)
            {
                FAWindow2 fAWindow2 = new FAWindow2(TbLogin.Text, TbPassword.Text);
                this.Close();
                fAWindow2.Show();
            }
            else
            {
                MessageBox.Show("Данный пользователь не найден");
            }

            //

        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            FAWindow1 fAWindow1 = new FAWindow1();
            this.Close();
            fAWindow1.Show();
        }
    }
}
