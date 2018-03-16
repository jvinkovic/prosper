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
            character = 1;
            gameInitialised = false;
            stageInitialised = false;
            stage = Stage.One;
            money = 0;
            happiness = 1;
            timerInterval = TimeSpan.FromSeconds(180);

            //setup the game timer
            Device.StartTimer(timerInterval, TimerElapsed);
            //GameStatsVM.UpdateMoney();
            
        }

        public int character;
        public bool gameInitialised;
        public bool stageInitialised;
        public TimeSpan timerInterval;
        public int money;
        public int happiness;

        public enum Stage
        {
            One,
            Two,
            Three
        };
        public Stage stage;

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
