using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PocketCloset.Controller;
using PocketCloset.Models;
using PocketCloset.Util;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

using Xamarin.Forms.Xaml;

namespace PocketCloset.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {

        private UserController userController;
        private User user;

        public HomePage(){
            InitializeComponent();
            Init();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            user = Application.Current.Properties[CommonSettings.GLOBAL_USER] as User;
            

        }
        public void Init()
        {
            BackgroundColor = Constants.backgroundColor;
            //boxViewPostDivider.Color = Constants.logoColor;

        }
       

        /* private void addPostFunction(object sender, EventArgs e)
         {
            // feedLayout.Children.Add(newPosts);
         }
         */
    }
}