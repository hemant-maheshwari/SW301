using System;
using System.Collections.Generic;
using PocketCloset.Controller;
using PocketCloset.Models;
using PocketCloset.Service;
using PocketCloset.Util;
using PocketCloset.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace PocketCloset.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FollowersPage : ContentPage
    {
        private UserController userController;
        private FollowerController followerController;
        private User user;
       

        public FollowersPage()
        {
            InitializeComponent();
            Init();
        }

        public async void Init()
        {
            BackgroundColor = Constants.backgroundColor;
            LoginIcon.HeightRequest = Constants.LoginIconHeight;
            boxViewFollower.Color = Constants.logoColor;
            followerController = new FollowerController();
            List<FollowViewModel> followers = await followerController.getAllFollowers(user.userId);
            //followerList.ItemsSource = followers;
        }
        public void goToHomePage(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavPage(user);
        }
        public void followerListItemTapped(object sender, ItemTappedEventArgs e)
        {
            Application.Current.MainPage = new AccountPage(/*e.Item*/);
        }
        public async void followerListPopulate()
        {  
           //  List<FollowViewModel> followers = await followerController.getAllFollowers(user.userId); 
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            user = Application.Current.Properties[CommonSettings.GLOBAL_USER] as User;


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
