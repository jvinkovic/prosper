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
            //start with no money
            MoneyTotal = 50;
            MoneyGoal = 100;;
            //start with full happiness
            Happiness = 1.0;
            timerInterval = TimeSpan.FromSeconds(180);

            //setup the game timer
            Device.StartTimer(timerInterval, TimerElapsed);
            
        }

        public int Character { get; set; }
        public bool GameInitialised { get; set; }
        public bool StageInitialised { get; set; }

        public TimeSpan timerInterval;
        public double MoneyTotal { get; set; }

        public double MoneyProgress
        {
            get
            {
                return this.MoneyTotal / this.MoneyGoal;
            }
        }

        public double MoneyGoal { get; set; }
        public double Happiness { get; set; }

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
