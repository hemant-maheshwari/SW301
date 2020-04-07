using System;
using System.Collections.Generic;
using PocketCloset.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PocketCloset.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FollowingPage : ContentPage
    {
        public FollowingPage()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            BackgroundColor = Constants.backgroundColor;
            LoginIcon.HeightRequest = Constants.LoginIconHeight;
            boxViewFollowing.Color = Constants.logoColor;
        }
        public void loginPageButton(object sender, EventArgs e)
        {
            App.Current.MainPage = new LoginPage();
        }
    }
}
