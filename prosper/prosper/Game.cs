using System;
using System.Collections.Generic;
using System.Text;

namespace prosper
{
    public class Game
    {
        public int character;
        public bool gameInitialised;
        public bool stageInitialised;
        public enum Stage
        {
            One,
            Two,
            Three
        };
        public Stage stage;
        public Game(int characterNum)
        {
            character = characterNum;
            gameInitialised = false;
            stageInitialised = false;
            Stage stage = Stage.One;
            
        }
        public void Tutorial()
        {
           //do something???
        }
    }
}
