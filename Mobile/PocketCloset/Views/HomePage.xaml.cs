using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PocketCloset.Models;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

using Xamarin.Forms.Xaml;

namespace PocketCloset.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : TabbedPage
    {
        public HomePage()
        {
            Xamarin.Forms.NavigationPage.SetHasBackButton(this, false);
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            BackgroundColor = Constants.backgroundColor;
            boxViewPostDivider.Color = Constants.logoColor;

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
       
         
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
        }
        public void logOutButton(object sender, EventArgs e)
        {
            App.Current.MainPage = new LoginPage();
        }
    }
}