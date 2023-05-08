namespace lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string isContinue;
            bool isChoosingSign = true;
            int countOfImposiibleWin =  4;
            int maxCountChoices = 9;

            Template template = new Template();
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");

            do
            {
                bool endGame = false;
                bool isDraw = false;
                string MainSign = "X";
                int numberOfChoise = 0;
                template.Upgrade();
                while (!endGame)
                {
                    if (isChoosingSign)
                    {
                        template.chooseSign(player1, player2);
                        isChoosingSign = false;
                    }
                    else
                    {
                        Player playerSign = template.Fill(player1, player2, MainSign);
                        chooseCell(playerSign.getCurrentSign());
                        if (numberOfChoise >= countOfImposiibleWin)
                        {
                            if (string.Equals(template.getCell(1), MainSign) && string.Equals(template.getCell(4), MainSign) && string.Equals(template.getCell(7), MainSign))
                            {
                                endGame = true;
                            }
                            else if (string.Equals(template.getCell(2), MainSign) && string.Equals(template.getCell(5), MainSign) && string.Equals(template.getCell(8), MainSign))
                            {
                                endGame = true;
                            }
                            else if (string.Equals(template.getCell(3), MainSign) && string.Equals(template.getCell(6), MainSign) && string.Equals(template.getCell(9), MainSign))
                            {
                                endGame = true;
                            }
                            else if (string.Equals(template.getCell(1), MainSign) && string.Equals(template.getCell(2), MainSign) && string.Equals(template.getCell(3), MainSign))
                            {
                                endGame = true;
                            }
                            else if (string.Equals(template.getCell(4), MainSign) && string.Equals(template.getCell(5), MainSign) && string.Equals(template.getCell(6), MainSign))
                            {
                                endGame = true;
                            }
                            else if (string.Equals(template.getCell(7), MainSign) && string.Equals(template.getCell(8), MainSign) && string.Equals(template.getCell(9), MainSign))
                            {
                                endGame = true;
                            }
                            else if (string.Equals(template.getCell(1), MainSign) && string.Equals(template.getCell(5), MainSign) && string.Equals(template.getCell(9), MainSign))
                            {
                                endGame = true;
                            }
                            else if (string.Equals(template.getCell(3), MainSign) && string.Equals(template.getCell(5), MainSign) && string.Equals(template.getCell(7), MainSign))
                            {
                                endGame = true;
                            }

                        }
                        numberOfChoise++;
                        if (numberOfChoise == maxCountChoices)
                        {
                            isDraw = true;
                            endGame = true;
                        }
                        if (!endGame)
                        {
                            if (string.Equals(MainSign, "X"))
                            {
                                MainSign = "0";
                            }
                            else
                            {
                                MainSign = "X";
                            }
                        }

                    }

                    template.Upgrade();

                    Player winPlayer;
                    if (endGame)
                    {
                        if (isDraw)
                        {
                            winResult("WoW DRAW!");
                        }
                        else
                        {
                            if (string.Equals(player1.getCurrentSign(), MainSign))
                            {
                                winPlayer = player1;
                            }
                            else
                            {
                                winPlayer = player2;
                            }
                                
                            winResult($"{winPlayer.getPlayerName()} U ARE WIN!");
                            winPlayer.addWin();
                        }

                    }

                }
                Console.Write("Do you want to play again? (y/n): ");
                bool finishError = false;
                do
                {
                    
                    isContinue = Console.ReadLine();
                    if (string.Equals(isContinue, "y") || string.Equals(isContinue, "n"))
                    {
                        finishError = true;
                    }
                    else
                    {
                        Validation validation = new Validation("finishError");
                    }
                        
                } while (!finishError);
                changeSign(player1);
                changeSign(player2);
                template.upgradeFields_Array();
            } while (string.Equals(isContinue, "y"));
            template.Upgrade();
            if (player1.getCountWin() > player2.getCountWin())
            {
                winResult($"{player1.getPlayerName()} IS WINNER!");
            }
            else if (player2.getCountWin() > player1.getCountWin())
            {
                winResult($"{player2.getPlayerName()} IS WINNER!");
            }
            else
            {
                winResult("DRAW!");
            }


            void chooseCell(string sign)
            {
                bool isValidNum = false;
                int num;
                do
                {
                    isValidNum = int.TryParse(Console.ReadLine(), out num);
                    if (isValidNum == false || num < 1 || num > 9)
                    {
                        Validation validation = new Validation("numError", num.ToString());
                        isValidNum = false;
                    }
                    else if (string.Equals(template.getCell(num), "X") || string.Equals(template.getCell(num), "0"))
                    {
                        Validation validation = new Validation("freeError");
                        isValidNum = false;
                    }
                    


                } while (!isValidNum);
                template.setCell(num, sign);
            }

            void winResult(string result)
            {
                global::System.Console.WriteLine($"{result}");
            }

            void changeSign(Player player)
            {
                if (string.Equals(player.getCurrentSign(), "X"))
                {
                    player.setCurrentSign("0");
                }
                else
                {
                    player.setCurrentSign("X");
                }
            }
        }

        


    }
}

