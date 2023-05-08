using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    internal class Player
    {
        private string currentSign;
        private string playerName;
        private int countWins;

        public Player(string playerName)
        {
            this.playerName = playerName;
            countWins = 0;
        }

        public void addWin()
        {
            countWins++;
        }

        public int getCountWin()
        {
            return countWins;
        }
        public void setCurrentSign(string currentSign)
        {
            this.currentSign = currentSign;
        }

        public string getCurrentSign()
        {
            return currentSign;
        }

        public string getPlayerName()
        {
            return playerName;
        }
    }
}
