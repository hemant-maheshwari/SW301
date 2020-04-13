using System;
using System.Collections.Generic;
using PocketCloset.Controller;
using PocketCloset.Models;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace PocketCloset.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FollowersPage : ContentPage
    {
        private UserController userController;
        private User user;
        public FollowersPage()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            BackgroundColor = Constants.backgroundColor;
            LoginIcon.HeightRequest = Constants.LoginIconHeight;
            boxViewFollower.Color = Constants.logoColor;
        }
        public void goToHomePage(object sender, EventArgs e)
        {
            App.Current.MainPage = new HomePage();
        }
        public void followerListItemTapped(object sender, ItemTappedEventArgs e)
        {
            Application.Current.MainPage = new AccountPage(/*e.Item*/);
        }
        public void followerListPopulate()
        {
         
        }
        public void isActivitySpinnerShowing(bool status)
        {
            if (status.Equals(true))
            {
                followerLayout.IsVisible = false;
                followerLayout.IsEnabled = false;
                activitySpinnerFollowerLayout.IsVisible = true;
                followerLoader.IsVisible = true;
                followerLoader.IsRunning = true;
                followerLoader.IsEnabled = true;

            }
            if (status.Equals(false))
            {
                activitySpinnerFollowerLayout.IsVisible = false;
                followerLayout.IsVisible = true;
                followerLayout.IsEnabled = true;
                followerLoader.IsVisible = false;
                followerLoader.IsRunning = false;
                followerLoader.IsEnabled = false;

            }
        }

    }
}
