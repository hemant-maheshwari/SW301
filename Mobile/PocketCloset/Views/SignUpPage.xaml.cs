using System;
using System.Collections.Generic;
using System.Linq;
using PocketCloset.Models;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PocketCloset.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
            Init();
        }
        void Init()
        {
            BackgroundColor = Constants.backgroundColor;
            Spinner.IsVisible = false;

        }
    }
}