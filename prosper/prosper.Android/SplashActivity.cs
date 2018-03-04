﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace prosper.Droid
{
    [Activity(Label = "Prosper", Icon = "@drawable/icon", Theme = "@style/splashscreen", ScreenOrientation = Android.Content.PM.ScreenOrientation.Landscape, MainLauncher = true, NoHistory = true)]
    public class SplashActivity : Activity
    {
        protected override void OnResume()
        {
            base.OnResume();
            Thread.Sleep(5000);
            StartActivity(typeof(MainActivity));
        }
    }
}