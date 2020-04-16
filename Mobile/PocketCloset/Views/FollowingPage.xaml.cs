using System;
using System.Collections.Generic;
using PocketCloset.Controller;
using PocketCloset.Models;
using PocketCloset.Util;
using PocketCloset.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace PocketCloset.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FollowingPage : ContentPage
    {
        private UserController userController;
        private FollowerController followerController;
        
      

        private User user;


        public FollowingPage()
        {
            InitializeComponent();
            Init();
        }

        public async void Init()
        {
            BackgroundColor = Constants.backgroundColor;
            LoginIcon.HeightRequest = Constants.LoginIconHeight;
            boxViewFollowing.Color = Constants.logoColor;
            BindingContext = followerController = new FollowerController();
            await followerController.getAllFollowing(user.userId);            
        }
        public void goToHomePage(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavPage(user);
        }
        public void followingListItemTapped(object sender, ItemTappedEventArgs e)
        {
            //Application.Current.MainPage = new AccountPage(user);
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
                followingLayout.IsVisible = false;
                followingLayout.IsEnabled = false;
                activitySpinnerFollowingLayout.IsVisible = true;
                followingLoader.IsVisible = true;
                followingLoader.IsRunning = true;
                followingLoader.IsEnabled = true;

            }
            if (status.Equals(false))
            {
                activitySpinnerFollowingLayout.IsVisible = false;
                followingLayout.IsVisible = true;
                followingLayout.IsEnabled = true;
                followingLoader.IsVisible = false;
                followingLoader.IsRunning = false;
                followingLoader.IsEnabled = false;

            }

        }
  
    }

}
