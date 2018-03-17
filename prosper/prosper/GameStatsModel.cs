using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xamarin.Forms;

namespace prosper
{
    public class GameStatsModel : INotifyPropertyChanged
    {
        double happiness, moneyProgress, moneyTotal;
        string roundTimer;
        //timer
        public Game game = Game.Instance;
        public event PropertyChangedEventHandler PropertyChanged;

        public string RoundTimer
        {
            set
            {
                if (roundTimer != value)
                {
                    roundTimer = value;
                    OnPropertyChanged("RoundTimer");
                    UpdateRoundTimer();
                    //update the round timer
                }
            }
            get
            {
                return game.TimerText;
            }
        }
        public double Happiness
        {
            set
            {
                if(happiness != value)
                {
                    happiness = value;
                    OnPropertyChanged("Happiness");
                    UpdateHappiness();
                }
            }
            get
            {
                return game.Happiness;
            }
        }
        public double MoneyProgress
        {
            set
            {
                if (moneyProgress != value)
                {
                   moneyProgress = value;
                    OnPropertyChanged("MoneyProgress");
                    UpdateMoneyProgress();
                }
            }
            get
            {
                return game.MoneyProgress;
            }
        }

        public double MoneyTotal
        {
            set
            {
                if (moneyTotal != value)
                {
                    moneyTotal = value;
                    OnPropertyChanged("MoneyTotal");
                    UpdateMoneyTotal();
                }
            }
            get
            {
                return game.MoneyTotal;
            }
        }
        public void UpdateHappiness()
        {
            happiness = game.Happiness;
        }
        public void UpdateMoneyProgress()
        {
            moneyProgress = game.MoneyProgress;
        }
        public void UpdateRoundTimer()
        {
            roundTimer = game.TimerText;
        }
        public void UpdateMoneyTotal()
        {
            moneyTotal = game.MoneyTotal;
        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
