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
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage(User user)
        {
            InitializeComponent();
            Init();
        }
        public SettingsPage()
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
        public void logOutButton(object sender, EventArgs e)
        {
            App.Current.MainPage = new LoginPage();
        }
    }
}