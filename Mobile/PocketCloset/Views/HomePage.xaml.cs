using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PocketCloset.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PocketCloset.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : TabbedPage
    {
        public HomePage()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            BackgroundColor = Constants.backgroundColor;
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