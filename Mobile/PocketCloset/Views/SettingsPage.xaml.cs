using PocketCloset.Controller;
using PocketCloset.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PocketCloset.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        private UserController userController;
        User user;
         
        public SettingsPage(User user)
        {
            InitializeComponent();
            Init();
            this.user = user;
        }

        public SettingsPage()
        {
            InitializeComponent();
        }

        public void Init()
        {
            BackgroundColor = Constants.backgroundColor;
            boxViewSettings.Color = Constants.logoColor;

            userController = new UserController();
            initializeAccountInfo();

        }

        private void initializeAccountInfo()
        {
            entryAccFirstName.Text = user.firstName;
            entryAccLastName.Text = user.lastName;
            entryAccEmail.Text = user.email;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();


        }
        public void logOut(object sender, EventArgs e)
        {
            App.Current.MainPage = new LoginPage();
        }

        public void updateUserForm(object sender, EventArgs e)
        {
            if (entryAccFirstName.Text == " " || entryAccFirstName.Text == null)
            {
                DisplayAlert("Invalid First Name", "Please enter your first name.", "Okay");
                entryAccFirstName.Focus();
            }
            else if (entryAccLastName.Text == " " || entryAccLastName.Text == null)
            {
                DisplayAlert("Invalid Last Name", "Please enter your last name.", "Okay");
                entryAccLastName.Focus();
            }
            else if (entryAccEmail.Text == null || !Regex.IsMatch(entryAccEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                DisplayAlert("Invalid Email", "Please enter a valid email.", "Okay");
                entryAccEmail.Focus();
                entryAccEmail.Text = "";
            }
            else if (entryAccPassword.Text == null || entryAccPassword.Text == "")
            {
                DisplayAlert("Invalid Password", "Please enter a valid password.", "Okay");
                entryAccPassword.Focus();
            }
            else if (entryAccConfirmPassword.Text == null || entryAccConfirmPassword.Text == "")
            {
                DisplayAlert("Invalid Confirmation", "Please enter your password again.", "Okay");
                entryAccConfirmPassword.Focus();
                entryAccConfirmPassword.Text = "";
            }
            else if (!passwordsMatch(entryAccPassword.Text, entryAccConfirmPassword.Text))
            {
                DisplayAlert("Invalid Password Confirmation", "Passwords do not match. Try again.", "Okay");
                entryAccConfirmPassword.Focus();
                entryAccConfirmPassword.Text = "";
            }
            else
            {
                isUpdateAccLayoutShowing(false);
                isActivitySpinnerShowing(true);
                updateUserAccount();

            }

        }

        public async void updateUserAccount()
        {
            user.updateUser(entryAccFirstName.Text, entryAccLastName.Text, entryAccEmail.Text, entryAccPassword.Text);
            try
            {
                bool flag = await userController.updateModel(user);
                if (flag)
                {
                    isActivitySpinnerShowing(false);
                    await DisplayAlert("Message", "User account updated successfully!", "Okay");
                    App.Current.MainPage = new LoginPage();
                }
                else
                {
                    isActivitySpinnerShowing(false);
                    isUpdateAccLayoutShowing(true);
                    await DisplayAlert("Message", "Error Occured!", "Okay");
                }
            }
            catch (Exception ex)
            {
                isActivitySpinnerShowing(false);
                isUpdateAccLayoutShowing(true);
                await DisplayAlert("Message", "Error Occured!", "Okay");
                Debug.WriteLine(ex.Message);
            }

        }

        private bool passwordsMatch(string password, string confirmPassword)
        {
            return password.Equals(confirmPassword);
        }

        private void isActivitySpinnerShowing(bool status)
        {
            if (status.Equals(true))
            {
                activitySpinnerLayout.IsVisible = true;
                activitySpinnerLayout.IsEnabled = true;
                updateAccLoader.IsRunning = true;
                updateAccLoader.IsEnabled = true;
                updateAccLoader.IsVisible = true;

            }
            else
            {
                activitySpinnerLayout.IsVisible = false;
                activitySpinnerLayout.IsEnabled = false;
                updateAccLoader.IsRunning = false;
                updateAccLoader.IsEnabled = false;
                updateAccLoader.IsVisible = false;

            }
        }

        private void isUpdateAccLayoutShowing(bool status)
        {
            if (status.Equals(true))
            {
                updateAccLayout.IsVisible = true;
                updateAccLayout.IsEnabled = true;
            }
            else
            {
                updateAccLayout.IsVisible = false;
                updateAccLayout.IsEnabled = false;
            }
        }
    }
}