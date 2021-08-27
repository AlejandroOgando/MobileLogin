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
       
        async void OnAlert()
        {
            await DisplayAlert("Aviso", "No pueden haber campos vacíos.", "OK");
        }

        async void LoginWelcome()
        {
            await DisplayAlert("Bienvenido", $"Hola, {usernameEntry.Text}", "OK");
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
