using PocketCloset.Controller;
using PocketCloset.Models;
using PocketCloset.Util;
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
    public partial class CreateOutfitPage : ContentPage
    {
        private UserController userController;
        private User user;
        public CreateOutfitPage(User user)
        {
            InitializeComponent();
            Init();

        }
        public CreateOutfitPage()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            BackgroundColor = Constants.backgroundColor;


        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            user = Application.Current.Properties[CommonSettings.GLOBAL_USER] as User;
            

        }
    }
}