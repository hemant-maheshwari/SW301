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
        private readonly List<string> searches = new List<string>
        {
           "Aaron", "Banson", "Hemant", "Logan", "Kyle"
        };
        public void searchButtonPressed(object sender, EventArgs e)
        {
            string keyword = searchPageBar.Text;
            IEnumerable<string> searchResults = searches.Where(name => name.Contains(keyword));
            searchPageList.ItemsSource = searchResults;
        }
        
        public HomePage()
        {
            Xamarin.Forms.NavigationPage.SetHasBackButton(this, false);
            InitializeComponent();
            Init();
            searchPageList.ItemsSource = searches;
        }
        public void Init()
        {
            BackgroundColor = Constants.backgroundColor;
            boxViewPostDivider.Color = Constants.logoColor;
           
            boxViewPostDivider2.Color = Constants.logoColor;

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