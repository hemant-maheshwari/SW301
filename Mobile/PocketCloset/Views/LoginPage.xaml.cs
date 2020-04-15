using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using PocketCloset.Controller;
using PocketCloset.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PocketCloset.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        private UserController userController;
        public LoginPage()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            BackgroundColor = Constants.backgroundColor;
            lblUsername.TextColor = Constants.initialScreensTextColor;
            lblPassword.TextColor = Constants.initialScreensTextColor;
            isActivitySpinnerShowing(false);
            userController = new UserController();
            LoginIcon.HeightRequest = Constants.LoginIconHeight;
            btnForgotPassword.TextColor = Constants.logoColor;
        }

        public void goToSignUpPage(object sender, EventArgs e)
        {
            App.Current.MainPage = new SignUpPage();
        }

        public void verifyLoginForm(object sender, EventArgs e)
        {
            if (entryUsername.Text == " " || entryUsername.Text == null)
            {
                DisplayAlert("Invalid username", "Please enter a username", "Okay");
                entryUsername.Focus();
            }
            else if (entryPassword.Text == " " || entryPassword.Text == null)
            {
                DisplayAlert("Invalid password", "Please enter a password.", "Okay");
                entryPassword.Focus();
            }
            else
            {
                isSignInLayoutShowing(false);
                isActivitySpinnerShowing(true);
                signIn();
            }
        }

        private async void signIn()
        {
            User user = new User(entryUsername.Text, entryPassword.Text);
            try
            {
                user = await checkUserExistence(user);
                if (user.userId != 0)
                {
                    //DisplayAlert("Login", "Login Success", "Okay");
                    App.Current.MainPage = new NavPage(user);          //PASS USER AS PARAMETER!!!!!!!!!!!!!!!!!
                }
                else
                {
                    isActivitySpinnerShowing(false);
                    isSignInLayoutShowing(true);
                    await DisplayAlert("Login Failed", "Incorrect Username or Password", "Try Again");
                }
            }
            catch (Exception e)
            {
                isActivitySpinnerShowing(false);
                isSignInLayoutShowing(true);
                entryUsername.Text = "";
                entryPassword.Text = "";
                await DisplayAlert("Message", "Error Occured!", "Okay");
                Debug.WriteLine(e.Message);
            }
        }

        private async Task<User> checkUserExistence(User user)
        {
            return await userController.checkUser(user);
        }

        private void isActivitySpinnerShowing(bool status)
        {
            if (status.Equals(true))
            {
                activitySpinnerLayout.IsVisible = true;
                activitySpinnerLayout.IsEnabled = true;
                signInLoader.IsVisible = true;
                signInLoader.IsEnabled = true;
                signInLoader.IsRunning = true;
            }
            else
            {
                activitySpinnerLayout.IsVisible = false;
                activitySpinnerLayout.IsEnabled = false;
                signInLoader.IsVisible = false;
                signInLoader.IsEnabled = false;
                signInLoader.IsRunning = false;
            }
        }

        private void isSignInLayoutShowing(bool status)
        {
            if (status.Equals(true))
            {
                signInLayout.IsEnabled = true;
                signInLayout.IsVisible = true;
            }
            else
            { 
                signInLayout.IsEnabled = false;
                signInLayout.IsVisible = false;
            }
        }

        public void goToForgotPasswordPage(object sender, EventArgs e)
        {
            App.Current.MainPage = new ForgotPasswordPage();
        }

        //public void goToNavPage(object sender, EventArgs e)     //DELETE WHEN PUSHING
        //{                                                        //DELETE WHEN PUSHING
        //    App.Current.MainPage = new NavPage();                //DELETE WHEN PUSHING
        //}
    }
}
