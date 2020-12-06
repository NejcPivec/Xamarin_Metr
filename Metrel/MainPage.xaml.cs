using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Metrel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Check if validate email
        Regex EmailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        public bool ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            return EmailRegex.IsMatch(email);
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        
         {
                bool isEmail = ValidateEmail(emailEntry.Text);
                bool isPasswordEmpty = string.IsNullOrEmpty(passwordEntry.Text);

                if (isEmail == false || isPasswordEmpty)
                {
                    ErrorLabel.Text = "Credentials are not correct!";
                }
                else
                {
                    Navigation.PushAsync(new HomePage());
                }
         }
        
    }
}
