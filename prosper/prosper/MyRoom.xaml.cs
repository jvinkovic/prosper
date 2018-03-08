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
        public Game game;
		public MyRoom (Game g)
		{
            InitializeComponent ();
            game = g;
            if (!game.gameInitialised)
            {
                TutorialPopup.IsVisible = true;
            }
            else if (!game.stageInitialised)
            {
                // if not initialised 
                // will see if this is a use case
                DisplayAlert("Code Check", "Nothing for loading page with game intialised but stage not initialised", "alright");
            }


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

        void OnPlayTutorial()
        {
           //when finished tutorial
            game.gameInitialised = true;
            TutorialPopup.IsVisible = false;
            //temporary
            DisplayAlert("Tutorial", "...awaiting implementation", "OK");
            // now initialise stage -- check first
                //TODO
        }
        void OnSkipTutorial()
        {
            game.gameInitialised = true;
            TutorialPopup.IsVisible = false;
            //now initialise stage -- check first
                //TODO
        }
    }
}