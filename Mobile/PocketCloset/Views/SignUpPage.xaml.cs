using System;
using System.Collections.Generic;
using System.Linq;
using PocketCloset.Models;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PocketCloset.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
            Init();
        }
        void Init()
        {
            BackgroundColor = Constants.backgroundColor;
            btnSignIn.TextColor = Constants.logoColor;
            Spinner.IsVisible = false;

        }
      
        public void signUpButton(object sender, EventArgs e)
        {
            App.Current.MainPage = new LoginPage();
        }

        public void goToLoginPage(object sender, EventArgs e)
        {
            App.Current.MainPage = new LoginPage();
        }
    }
}