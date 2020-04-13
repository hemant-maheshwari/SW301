using PocketCloset.Controller;
using PocketCloset.Models;
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

        public SearchPage(User user)
        {
            InitializeComponent();
            this.user = user;
            searchLoader.IsVisible = false;
        }
        public SearchPage()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            BackgroundColor = Constants.backgroundColor;
            userController = new UserController();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private void searchSuggestionsItemTapped(object sender, ItemTappedEventArgs e)
        {
            Application.Current.MainPage = new AccountPage(/*searchSuggestions*/);
        }

        public void searchButtonPressed(object sender, EventArgs e)
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
        
         private async void searchUser()
        {
            isActivitySpinnerShowing(true);
            try
            {
                User foundUser = await getUserFromUsername(searchPageBar.Text);
                if (foundUser != null)
                {
                    isActivitySpinnerShowing(false);

                    user = foundUser;
                   
                    searchSuggestions.ItemsSource = foundUser.username;
                }
                else
                {
                     await DisplayAlert("Message", "User not Found", "Okay");
                }
            }
            catch (Exception ex)
            {
                isActivitySpinnerShowing(false);
                await DisplayAlert("Error", "Error occurred.", "Okay");
                Debug.WriteLine(ex.Message);
            }
        }

        private async Task<User> getUserFromUsername(string username)
        {
            return await userController.getUserFromUsername(username);
        }
        

        public void isActivitySpinnerShowing(bool status)
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