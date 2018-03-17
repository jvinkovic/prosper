using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;


namespace prosper
{
    class MyRoomViewModel : INotifyPropertyChanged
    {
        bool tutorialPopupVisible = false;
        bool stagePopupVisible = false;
        bool characterVisible = false;
        string stagePopupTitle;
        string stagePopupText;
        string stageBeginText;
        string characterImageSource;
        public Game game = Game.Instance;
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand PlayTutorialCommand { get; private set; }
        public ICommand SkipTutorialCommand { get; private set; }
        public ICommand BeginStageCommand { get; private set; }

        public MyRoomViewModel()

        {
            PlayTutorialCommand = new Command(OnPlayTutorial);
            SkipTutorialCommand = new Command(OnSkipTutorial);
            BeginStageCommand = new Command(OnStageBegin);
            AddCharacterToScreen(game.Character);
            if (!game.GameInitialised)
            {
                TutorialPopupVisible = true;
            }
            else if (!game.StageInitialised)
            {
                // if not initialised 
                // will see if this is a use case
                Application.Current.MainPage.DisplayAlert("Code Check", "Nothing for loading page with game intialised but stage not initialised", "Alright");
            }
        }
        void OnPlayTutorial()
        {
            //when finished tutorial
            game.GameInitialised = true;
            TutorialPopupVisible = false;
            //temporary
            Application.Current.MainPage.DisplayAlert("Tutorial", "...awaiting implementation", "OK");
            if (!game.StageInitialised)
            {
                InitialiseStage();
            }
        }
        void OnSkipTutorial()
        {
            game.GameInitialised = true;
            TutorialPopupVisible = false;
            if (!game.StageInitialised)
            {
                InitialiseStage();
            }
        }
        void OnStageBegin()
        {
            game.StageInitialised = true;
            StagePopupVisible = false;
        }

        void InitialiseStage()
        {

            if (game.GameStage == Game.Stage.One)
            {
                StagePopupTitle = "Stage 1";
                StagePopupText = "The objective of stage 1 is to save $100 to purchase a mobile phone." +
                    "\nYou can earn money from doing chores for pocket money." +
                    "\nTo avoid running low on happiness you can buy items from the shop.";
                StageBeginText = "Begin Stage 1!";
            }
            else if (game.GameStage == Game.Stage.Two)
            {
                StagePopupTitle = "Stage 2";
                StagePopupText = "The objective of stage 2 is to save $1000 to purchase a car." +
                    "\nYou can now earn money faster from working different jobs." +
                    "\nYou will now pay extra bills per round for your phone";
                StageBeginText = "Begin Stage 2!";
            }
            else if (game.GameStage == Game.Stage.Three)
            {
                StagePopupTitle = "Stage 3";
                StagePopupText = "The objective of stage 3 is to save $5000 to purchase a holiday." +
                    "\nYou can now also earn money through investing - see Manage $." +
                    "\nYou will now pay extra bills per round for your car.";
                StageBeginText = "Begin Stage 3!";
            }
            StagePopupVisible = true;
        }

        void AddCharacterToScreen(int characterNum)
        {
            switch (characterNum)
            {
                case 1:
                    CharacterImageSource = "char1.png";
                    break;
                case 2:
                    CharacterImageSource = "char2.png";
                    break;
                case 3:
                    CharacterImageSource = "char3.png";
                    break;
                default:
                    //should throw an error I think
                    break;
            }
            CharacterVisible = true;
        }
        public bool TutorialPopupVisible
        {
            get
            {
                return tutorialPopupVisible;
            }
            set
            {
                tutorialPopupVisible = value;
                OnPropertyChanged("TutorialPopupVisible");
            }
        }
        public bool CharacterVisible
        {
            get
            {
                return characterVisible;
            }
            set
            {
                characterVisible = value;
                OnPropertyChanged("CharacterVisible");
            }
        }
        public bool StagePopupVisible
        {
            get
            {
                return stagePopupVisible;
            }
            set
            {
                stagePopupVisible = value;
                OnPropertyChanged("StagePopupVisible");
            }
        }
        public string StagePopupTitle
        {
            get
            {
                return stagePopupTitle;
            }
            set
            {
                stagePopupTitle = value;
                OnPropertyChanged("StagePopupTitle");
            }
        }
        public string StagePopupText
        {
            get
            {
                return stagePopupText;
            }
            set
            {
                stagePopupText = value;
                OnPropertyChanged("StagePopupText");
            }
        }
        public string StageBeginText
        {
            get
            {
                return stageBeginText;
            }
            set
            {
                stageBeginText = value;
                OnPropertyChanged("StageBeginText");
            }
        }
        public string CharacterImageSource
        {
            get
            {
                return characterImageSource;
            }
            set
            {
                characterImageSource = value;
                OnPropertyChanged("CharacterImageSource");
            }
        }



        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
