using PocketCloset.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PocketCloset.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage(User user)
        {
            InitializeComponent();
            Init();
        }
        public ProfilePage()
        {
            InitializeComponent();
        }
        public void Init()
        {
            BackgroundColor = Constants.backgroundColor;

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();


        }
        public void goToFollowersPage(object sender, EventArgs e)
        {
            App.Current.MainPage = new FollowersPage();
        }

        public void goToFollowingPage(object sender, EventArgs e)
        {
            App.Current.MainPage = new FollowingPage();
        }
        public void goToAccountPage(object sender, EventArgs e)
        {
            App.Current.MainPage = new AccountPage();
        }
    }
}