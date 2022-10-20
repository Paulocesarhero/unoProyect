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
using UnoEntitys;
using unoProyect.Security;

namespace unoProyect
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        Logic.SignUp logicSU = new Logic.SignUp();
        public Login()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var username = tbUser.Text;
            var password = pbPassword.Password.ToString();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show(Properties.Resources.notEmptyFields,
                            Properties.Resources.error);
            }
            else
            {
                password = Utilities.ComputeSHA256Hash(password);
                var result = logicSU.ItsAUser(username, password);
                if (!logicSU.ItsAUser(username, password))
                {
                    MessageBox.Show(Properties.Resources.wrongCredentials, 
                        Properties.Resources.error);    
                }
                else
                {
                    MessageBox.Show(Properties.Resources.welcome + " " + username,
                        "");
                }
                Console.WriteLine("Este es el resultado: " + result);
            }
        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            SignUp signUp = new SignUp();
            this.NavigationService.Navigate(signUp);

        }
    }
}
