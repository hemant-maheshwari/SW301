using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PocketCloset.Controller;
using PocketCloset.Models;
using PocketCloset.Util;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PocketCloset.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccountPage : ContentPage
    {
        private UserController userController;
        private User user;
        public AccountPage()
        {
            InitializeComponent();
            Init();
        }

        void Init()  //initializes the components of page
        {
            BackgroundColor = Constants.backgroundColor;
            boxViewAccountPage.Color = Constants.logoColor;
        }

        protected override void OnAppearing() // brings user to page when clicked on
        {
            base.OnAppearing();
            user = Application.Current.Properties[CommonSettings.GLOBAL_USER] as User;
        }

    }
}