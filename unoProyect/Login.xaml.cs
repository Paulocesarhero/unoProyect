﻿using System;
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
            credentials _credentials = new credentials
            {
                username = tbUser.Text,
                password = pbPassword.Password
            };
            var result = logicSU.itsAUser(_credentials);
            Console.WriteLine("Este es el resultado: " + result);

        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            SignUp signUp = new SignUp();
            this.NavigationService.Navigate(signUp);

        }
    }
}
