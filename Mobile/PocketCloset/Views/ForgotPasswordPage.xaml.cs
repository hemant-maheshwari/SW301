using PocketCloset.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PocketCloset.Views
{
    public partial class ForgotPasswordPage : ContentPage
    {
        public ForgotPasswordPage()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            BackgroundColor = Constants.backgroundColor;
        }
        public void loginPageButton(object sender, EventArgs e)
        {
            App.Current.MainPage = new LoginPage();
        }

        public void sendResetLink(System.Object sender, System.EventArgs e)
        {
        }
    }
}
