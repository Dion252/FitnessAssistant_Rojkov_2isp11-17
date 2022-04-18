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
using FitnessAssistant_Rojkov_2isp11_17.DataBase;
using FitnessAssistant_Rojkov_2isp11_17.DataClass;
using FitnessAssistant_Rojkov_2isp11_17.Windows;

namespace FitnessAssistant_Rojkov_2isp11_17.Windows
{
    /// <summary>
    /// Логика взаимодействия для FAWindow1.xaml
    /// </summary>
    public partial class FAWindow1 : Window
    {
        public FAWindow1()
        {
            InitializeComponent();

            Genderbox.ItemsSource = AppData.Context.Gender.ToList();

            Genderbox.DisplayMemberPath = "Title";

            Genderbox.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataBase.User user = new DataBase.User();

            user.Login = txtLogin.Text;
            user.Password = txtPassword.Text;
            user.Lastname = txtLastName.Text;
            user.Firstname = txtFirstName.Text;
            user.Height = Convert.ToInt32(txtHeight.Text);
            user.Weight = Convert.ToInt32(txtWeight.Text);
            user.DateBirth = Convert.ToDateTime(txtDateBirth.Text);
            user.GenderCode = Genderbox.SelectedIndex + 1;


            AppData.Context.User.Add(user);
            AppData.Context.SaveChanges();
            MessageBox.Show("Регистрация прошла успешно", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);


            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

            this.Close();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
