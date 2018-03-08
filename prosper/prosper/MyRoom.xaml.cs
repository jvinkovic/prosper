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
            AddCharacterToScreen(game.character);

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
            if (!game.stageInitialised)
            {
                InitialiseStage();
            }

        }
        void InitialiseStage()
        {

            if (game.stage == Game.Stage.One)
            {
                StagePopupTitle.Text = "Stage 1";
                StagePopupText.Text = "The objective of stage 1 is to save $100 to purchase a mobile phone." +
                    "\nYou can earn money from doing chores for pocket money." +
                    "\nTo avoid running low on happiness you can buy items from the shop.";
                StageBeginText.Text = "Begin Stage 1!";
            }
            else if (game.stage == Game.Stage.Two)
            {
                StagePopupTitle.Text = "Stage 2";
                StagePopupText.Text = "The objective of stage 2 is to save $1000 to purchase a car." +
                    "\nYou can now earn money faster from working different jobs." +
                    "\nYou will now pay extra bills per round for your phone";
                StageBeginText.Text = "Begin Stage 2!";
            }
            else if (game.stage == Game.Stage.Three)
            {
                StagePopupTitle.Text = "Stage 3";
                StagePopupText.Text = "The objective of stage 3 is to save $5000 to purchase a holiday." +
                    "\nYou can now also earn money through investing - see Manage $." +
                    "\nYou will now pay extra bills per round for your car.";
                StageBeginText.Text = "Begin Stage 3!";
            }
            StagePopup.IsVisible = true;
        }
        void OnSkipTutorial()
        {
            game.gameInitialised = true;
            TutorialPopup.IsVisible = false;
            if (!game.stageInitialised)
            {
                InitialiseStage();
            }
        }
        void OnStageBegin()
        {
            game.stageInitialised = true;
            StagePopup.IsVisible = false;
        }
        void AddCharacterToScreen(int characterNum)
        {
           switch (characterNum)
            {
                case 1:
                    Character.Source = "char1.png";
                    break;
                case 2:
                    Character.Source = "char2.png";
                    break;
                case 3:
                    Character.Source = "char3.png";
                    break;
                default:
                    //should throw an error I think
                    break;
            }
            Character.IsVisible = true;
        }

    }
}