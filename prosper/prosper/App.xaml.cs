using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace prosper
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            //set MainPage as root NavigationPage
            MainPage = new NavigationPage(new SelectCharacter());
            //MainPage = new prosper.MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
