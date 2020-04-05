using System;
using System.Collections.Generic;
using PocketCloset.Models;
using Xamarin.Forms;

namespace PocketCloset.Views
{
    public partial class ForgotPasswordPage : ContentPage
    {
        public ForgotPasswordPage()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            BackgroundColor = Constants.backgroundColor;
        }

        public void sendResetLink(System.Object sender, System.EventArgs e)
        {
        }
    }
}
