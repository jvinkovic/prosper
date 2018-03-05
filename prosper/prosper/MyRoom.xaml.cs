using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prosper
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyRoom : ContentPage
	{
		public MyRoom ()
		{
            //doesn't do anything
            //DisplayAlert("HEY", "Before Component Intisialised", "HELLO");
            InitializeComponent ();
            //BoxView tutorial = new BoxView()
            //{

            //}
            //Button button = new Button
            //{
              //  Text = "Navigate!",
                //HorizontalOptions = LayoutOptions.Center,
                //VerticalOptions = LayoutOptions.Center
            //};

            PlayTutorial();
		}
        void OnRandomSelect()
        {
            DisplayAlert("Random Event", "This RANDOM thing HAPPENED", "ok");
        }
        void OnShopSelect()
        {
            DisplayAlert("Shop", "This is when the shop will display... awaiting implementation", "ok");
        }

        async void OnEarnMoneySelect()
        {

            await Navigation.PushAsync(new EarnMoney());
        }
        async void OnManageMoneySelect()
        {
            await Navigation.PushAsync(new ManageMoney());
        }
        void PlayTutorial()
        {
            DisplayAlert("Tutorial", "Would you like to play the tutorial", "Yes", "No");
        }

    }
}