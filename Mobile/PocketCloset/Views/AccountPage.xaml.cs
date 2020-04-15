using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PocketCloset.Models;
using PocketCloset.Util;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PocketCloset.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccountPage : ContentPage
    {
        private User user;
        public AccountPage()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            BackgroundColor = Constants.backgroundColor;
            boxViewAccountPage.Color = Constants.logoColor;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            user = Application.Current.Properties[CommonSettings.GLOBAL_USER] as User;
        }

    }
}