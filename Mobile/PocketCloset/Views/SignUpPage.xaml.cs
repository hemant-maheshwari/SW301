using System;
using System.Collections.Generic;
using System.Linq;
using PocketCloset.Models;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Text.RegularExpressions;

namespace PocketCloset.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
            Init();
        }
        void Init()
        {
            BackgroundColor = Constants.backgroundColor;
            btnSignIn.TextColor = Constants.logoColor;
            Spinner.IsVisible = false;

        }
      
        public void signUpButton(object sender, EventArgs e)
        {
            if (pickerUserType == null)
            {
                DisplayAlert("Invalid User Type", "Please select a user type.", "Okay");
                pickerUserType.Focus();
            }
            else if (entryFirstName.Text == " " || entryFirstName.Text == null)
            {
                DisplayAlert("Invalid First Name", "Please enter your first name.", "Okay");
                entryFirstName.Focus();
            }
            else if (entryLastName.Text == " " || entryLastName.Text == null)
            {
                DisplayAlert("Invalid Last Name", "Please enter your last name.", "Okay");
                entryLastName.Focus();
            }
            else if (entryEmail.Text == null || !Regex.IsMatch(entryEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                DisplayAlert("Invalid Email", "Please enter a valid email.", "Okay");
                entryEmail.Focus();
                entryEmail.Text = "";
            }
            else if (entryUsername.Text == null || entryUsername.Text == "")
            {
                DisplayAlert("Invalid Username", "Please enter a valid username", "Okay");
                entryUsername.Focus();
            }
            else if (entryPassword.Text == null || entryPassword.Text == "")
            {
                DisplayAlert("Invalid Password", "Please enter a valid password.", "Okay");
                entryPassword.Focus();
            }
            else if (entryConfirmPassword.Text == null || entryConfirmPassword.Text == "")
            {
                DisplayAlert("Invalid Confirmation", "Please enter your password again.", "Okay");
                entryConfirmPassword.Focus();
                entryConfirmPassword.Text = "";
            }
            else if (entryConfirmPassword.Text != entryPassword.Text)
            {
                DisplayAlert("Invalid Password Confirmation", "Passwords do not match. Try again.", "Okay");
                entryConfirmPassword.Focus();
                entryConfirmPassword.Text = "";
            }else if (entryPhoneNumber.Text.Length < 10 || entryPhoneNumber.Text.Length > 11)
            {
                DisplayAlert("Invalid Phone Number", "Invalid phone number. Try again", "Okay");
                entryPhoneNumber.Focus();
                entryPhoneNumber.Text = "";
            }
            else
            {
                App.Current.MainPage = new HomePage();
            }
        }

        public void goToLoginPage(object sender, EventArgs e)
        {
            App.Current.MainPage = new LoginPage();
        }
    }
}