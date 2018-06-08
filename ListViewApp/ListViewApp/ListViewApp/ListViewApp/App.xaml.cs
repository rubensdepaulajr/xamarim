using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ListViewApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new ListViewApp.MainPage();
            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.FromRgb(0, 133, 165),
                BarTextColor = Color.White
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
