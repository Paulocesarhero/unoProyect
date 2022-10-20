using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace unoProyect
{
    /// <summary>
    /// Lógica de interacción para SignUp.xaml
    /// </summary>
    public partial class SignUp : Page
    {
        Logic.SignUp logicSU = new Logic.SignUp();
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            /*credentials _credentials = new credentials();
            _credentials.password = pbPassword.Password;
            _credentials.username = tbUser.Text;
            _credentials.email = tbEmail.Text;
             var result = logicSU.addCredentials(_credentials);
            Console.WriteLine(result);*/
            var result = logicSU.addFriends(1,3);
        }
    }
}
