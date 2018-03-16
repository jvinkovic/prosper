using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xamarin.Forms;

namespace prosper
{
    public class GameStatsVM : INotifyPropertyChanged
    {
        double happiness, money;
        double roundTimer;
        //timer

        public event PropertyChangedEventHandler PropertyChanged;

        public double RoundTimer
        {
            set
            {
                if (roundTimer != value)
                {
                    roundTimer = value;
                    OnPropertyChanged("RoundTimer");
                    //update the round timer
                }
            }
            get
            {
                return roundTimer;
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
                return happiness;
            }
        }
        public double Money
        {
            set
            {
                if (money != value)
                {
                   money = value;
                    OnPropertyChanged("Money");
                    UpdateMoney();
                }
            }
            get
            {
                return money;
            }
        }
        public void UpdateHappiness()
        {
            Happiness = 0.4;
        }
        public void UpdateMoney()
        {
            Money = 50;
        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
