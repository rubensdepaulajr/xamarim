﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CrudSQLite
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new CrudSQLite.MainPage();
            MainPage = new NavigationPage(new ClientesPage())
            {
                BarBackgroundColor = Color.FromHex("008542")
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
