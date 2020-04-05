using System;
using System.Collections.Generic;
using PocketCloset.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PocketCloset.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FollowersPage : ContentPage
    {
        public FollowersPage()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            BackgroundColor = Constants.backgroundColor;
            LoginIcon.HeightRequest = Constants.LoginIconHeight;
            boxViewFollowers.Color = Constants.logoColor;
        }

    }
}
