﻿using System;
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
    public partial class HomePage : ContentPage
    {
        public HomePage(User user)
        {

            InitializeComponent();
            Init();
        }
        public HomePage(){
            InitializeComponent();
        }
        public void Init()
        {
            BackgroundColor = Constants.backgroundColor;
            //boxViewPostDivider.Color = Constants.logoColor;

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
        
       /* private void addPostFunction(object sender, EventArgs e)
        {
           // feedLayout.Children.Add(newPosts);
        }
        */
    }
}