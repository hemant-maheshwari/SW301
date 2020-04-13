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
    public partial class CreateOutfitPage : ContentPage
    {
        public CreateOutfitPage(User user)
        {
            InitializeComponent();
            Init();

        }
        public CreateOutfitPage()
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
    }
}