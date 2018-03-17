using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prosper
{
    public sealed class Game
    {
        //implement static initilisation Singleton pattern - Reference, https://msdn.microsoft.com/en-au/library/ff650316.aspx
        private static readonly Game instance = new Game();
       
        public static Game Instance
        {
            get
            {
                return instance;
            }
        }
        private Game()
        {
            Character = 1;
            GameInitialised = false;
            StageInitialised = false;
            GameStage = Stage.One;
            MoneyTotal = 0;
            MoneyGoal = 100;
            MoneyProgress = 0;
            Happiness = 1;
            timerInterval = TimeSpan.FromSeconds(180);

            //setup the game timer
            Device.StartTimer(timerInterval, TimerElapsed);
            //GameStatsVM.UpdateMoney();
            
        }

        public int Character { get; set; }
        public bool GameInitialised { get; set; }
        public bool StageInitialised { get; set; }

        public TimeSpan timerInterval;
        public int MoneyTotal { get; set; }

        public int MoneyProgress { get; set; }

        public int MoneyGoal { get; set; }
        public int Happiness { get; set; }

        public enum Stage
        {
            One,
            Two,
            Three
        };
        public Stage GameStage { get; set; }

        private bool TimerElapsed()
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                // look into semaphore in C. Look into pthreads in C. Generally look at concurrency in C, you should be able to reference the libraries needed.
                // 
                
            });
            //return true to keep timer reccuring
            return true;

            //return false to stop timer
        }

    }
}
