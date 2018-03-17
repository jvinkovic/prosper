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
            int secs = 30;
            int mins = 0;
            StartTimer( mins, secs);
            //Device.StartTimer(timerInterval, TimerElapsed);


        }
        public bool isTimerCancel { get; set; } = false;
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
        public string TimerText { get; set; }

        public enum Stage
        {
            One,
            Two,
            Three
        };
        public Stage GameStage { get; set; }

        /*
        private bool TimerElapsed()
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                // look into semaphore in C. Look into pthreads in C. Generally look at concurrency in C, you should be able to reference the libraries needed.
                TimerText = 
                
            });
            //return true to keep timer reccuring
            return true;

            //return false to stop timer
        }
        */

        public void StartTimer(int m, int sec)
        {
            int mins = m;
            int counter = sec;
            Device.StartTimer(new TimeSpan(0, 0, 1), () =>
            {
                if (isTimerCancel)
                {
                    return false;
                }
                else
                {
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        counter = counter - 1;
                        if (counter < 0)
                        {
                            counter = 59;
                            mins = mins - 1;
                            if (mins < 0)
                            {
                                    mins = 0;
                                    counter = 0;
                            }
                        }

                        TimerText = string.Format("{0:00}:{1:00}", mins, counter);
                    });
                    if ( mins == 0 && counter == 0)
                    {
                        //what to do when the timer finishes
                        //TODO will need to reduce happiness
                        Happiness -= 0.1;
                        //TODO will need to deduct bills depeneding on stage
                        //restart the timer again
                        StartTimer(0, 30);
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            });

        }
    }
}
