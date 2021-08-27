using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace pract1_mobile
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }
       
        void OnAlert()
        {
            UserDialogs.Instance.Toast("No pueden haber campos vacíos.", TimeSpan.FromSeconds(3));
        }

        void LoginWelcome()
        {
            UserDialogs.Instance.Toast($"Bienvenido, {usernameEntry.Text}",TimeSpan.FromSeconds(3));
        }
        void OnButtonClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameEntry.Text) || string.IsNullOrWhiteSpace(passwordEntry.Text))
            {
                OnAlert();
            }
            else
            {
                LoginWelcome();
            }
        }

        
    }
}
