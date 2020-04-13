using PocketCloset.Models;
using PocketCloset.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace PocketCloset.ViewModels
{
    class NavPageViewModel
    {
        public HomePage homepageTab { set; get; }
        public SearchPage searchpageTab { set; get; }
        public CreateOutfitPage createoutfitpageTab { set; get; }
        public ProfilePage profilepageTab { set; get; }
        public SettingsPage settingspageTab { set; get; }

        public NavPageViewModel(User user)
        {
            var homepageTab = new HomePage(user);
            var searchpageTab = new SearchPage(user);
            var createoutfitTab = new CreateOutfitPage(user);
            var profilepageTab = new ProfilePage(user);
            var settingspageTab = new SettingsPage(user);
        }

        
    }
}
