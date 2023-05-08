using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    internal class Template
    {
        private string[] fields_array;

        public Template()
        {
            fields_array = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        }

        public void setCell(int cellNumber, string sign)
        {
            fields_array[cellNumber-1] = sign;
        } 

        public string getCell(int cellNumber)
        {
            return fields_array[cellNumber - 1];
        }

        public void upgradeFields_Array()
        {
            fields_array = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        }

        public Player Fill(Player player1, Player player2, string MainSign)
        {
            string currentChooserName;
            Player currentPlayer;
            if (string.Equals(player1.getCurrentSign(), MainSign))
            {
                currentChooserName = player1.getPlayerName();
                currentPlayer = player1;
            }
            else
            {
                currentChooserName=player2.getPlayerName();
                currentPlayer=player2;
            }

            Console.WriteLine("Lets play TIC TAC TOE!\n\n");
            Console.WriteLine($"{player1.getPlayerName()}: {player1.getCurrentSign()} [{player1.getCountWin()}]");
            Console.WriteLine($"{player2.getPlayerName()}: {player2.getCurrentSign()} [{player2.getCountWin()}]\n");

            Console.WriteLine($" {fields_array[0]} | {fields_array[1]} | {fields_array[2]} \n" +
                                   "---+---+---\n" +
                                   $" {fields_array[3]} | {fields_array[4]} | {fields_array[5]} \n" +
                                   "---+---+---\n" +
                                   $" {fields_array[6]} | {fields_array[7]} | {fields_array[8]} \n");
            
              Console.Write($"\n{currentChooserName} turn. Select from 1 to 9 from the game board: ");

            return currentPlayer;

        }

        public void Upgrade()
        {
            Console.Clear();
        }

        public void chooseSign(Player player1, Player player2)
        {
            Console.WriteLine("Lets play TIC TAC TOE!\n\n");
            Console.Write($"{player1.getPlayerName()} choose X or 0: ");
            bool isValidSign = false;
            string sign;
            do
            {
                sign = Console.ReadLine();
                if (string.Equals(sign, "X") || string.Equals(sign, "0"))
                {
                    isValidSign = true;
                }
                else
                {
                    Validation validation = new Validation("signError");
                }


            } while (!isValidSign);
            
            player1.setCurrentSign(sign);
            if (string.Equals(sign, "X"))
                player2.setCurrentSign("0");
            else
                player2.setCurrentSign("X");
            
        }

        
        
    }
}
