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
using FitnessAssistant_Rojkov_2isp11_17.DataClass;
using FitnessAssistant_Rojkov_2isp11_17.DataBase;
using FitnessAssistant_Rojkov_2isp11_17.Windows;

namespace FitnessAssistant_Rojkov_2isp11_17.Windows
{
    /// <summary>
    /// Логика взаимодействия для FAWindow2.xaml
    /// </summary>
    public partial class FAWindow2 : Window
    {
        public FAWindow2(string login, string password)
        {
            InitializeComponent();


            var item = AppData .Context.User.ToList().Where(i => i.Login == login && i.Password == password).FirstOrDefault();
            TbAge.Text = Convert.ToString(item.Age);
            TbHeight.Text = Convert.ToString(item.Height);
            TbWeight.Text = Convert.ToString(item.Weight);
            double bmi = Calculation.BMI(item.Weight, item.Height);

            TbBMI.Text = Convert.ToString(Math.Round(bmi));

            string BMR = Convert.ToString(Calculation.BMR(Convert.ToString(item.GenderCode), item.Weight, item.Height, item.Age));

            TbBMR.Text = BMR;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FAWindow1 fAWindow1 = new FAWindow1();
            fAWindow1.Show();
            this.Close();
        }
    }
}
