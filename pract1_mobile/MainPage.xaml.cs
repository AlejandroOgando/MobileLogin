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
        string emailDataEntry, passwordDataEntry;
        
        public MainPage()
        {
            InitializeComponent();
        }
        void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            emailDataEntry = e.NewTextValue;
            
        }

        void PasswordEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            passwordDataEntry = e.NewTextValue;
        }

        async void OnAlert()
        {
            await DisplayAlert("Aviso", "No pueden haber campos vacíos.", "OK");
        }

        async void LoginWelcome()
        {
            await DisplayAlert("Bienvenido", "Hola, "+ emailDataEntry, "OK");
        }
        void OnButtonClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailDataEntry) || string.IsNullOrWhiteSpace(passwordDataEntry))
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
