using PocketCloset.Controller;
using PocketCloset.Models;
using PocketCloset.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PocketCloset.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchPage : ContentPage
    {
        private UserController userController;
        private User user;

        public SearchPage()
        {
            InitializeComponent();
            Init();
        }
        public void Init() //initialize screen components
        {
            BackgroundColor = Constants.backgroundColor;
            userController = new UserController();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            user = Application.Current.Properties[CommonSettings.GLOBAL_USER] as User;
        }
        public void goToUserAccount(object sender, EventArgs e) //navigate to user account page
        {   
            Application.Current.MainPage = new AccountPage();
        }
        public void searchButtonPressed(object sender, EventArgs e) //function when search button is pressed
        {
            var keyword = searchPageBar.Text;
               
            if (keyword.Length < 3 || keyword.Length > 20)
            {
                isActivitySpinnerShowing(false);
                DisplayAlert("Invalid Search", "Enter a valid UserName", "Okay");
                searchPageBar.Focus();
            }
            else 
            {
                isActivitySpinnerShowing(true);
                searchUser();
            }
        }
        
         private async void searchUser() // searches database for matching user
        {
            isActivitySpinnerShowing(true);
            try
            {
                User foundUser = await getUserFromUsername(searchPageBar.Text);
                if (foundUser != null)
                {
                    isActivitySpinnerShowing(false);

                    user = foundUser;
                   
                    searchSuggestions.Text = foundUser.username;
                    searchSuggestions.IsVisible = true;
                }
                else
                {
                     await DisplayAlert("Message", "User not Found", "Okay");
                    isActivitySpinnerShowing(false);
                }
            }
            catch (Exception ex)
            {
                isActivitySpinnerShowing(false);
                await DisplayAlert("Error", "Error occurred.", "Okay");
                Debug.WriteLine(ex.Message);
            }
        }

        private async Task<User> getUserFromUsername(string username) // calls for user from rest api
        {
            return await userController.getUserFromUsername(username);
        }
        

        public void isActivitySpinnerShowing(bool status) //determines the visibility activity spinner
        {
            if (status.Equals(true))
            {
                searchLayout.IsVisible = false;
                searchLayout.IsEnabled = false;
                activitySpinnerSearchLayout.IsVisible = true;
                searchLoader.IsVisible = true;
                searchLoader.IsRunning = true;
                searchLoader.IsEnabled = true;
                
               
            }
            if (status.Equals(false))
            {
                activitySpinnerSearchLayout.IsVisible = false;
                searchLayout.IsVisible = true;
                searchLayout.IsEnabled = true;
                searchLoader.IsVisible = false;
                searchLoader.IsRunning = false;
                searchLoader.IsEnabled = false;
                
            }
        }
    }
}