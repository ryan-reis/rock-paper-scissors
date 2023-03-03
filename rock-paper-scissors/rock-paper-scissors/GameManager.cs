//Written by Zachary Skinner and Ryan
//3/1/2023
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scissors
{
    public class GameManager
    {
        public void PlayRockPaperScissors()
        {
            string winner = "";
            Console.WriteLine("Player 1 Enter 1 for Rock, 2 for Paper, 3 for Scissors, 4 for Lizard, or 5 for Spock" + "\n");
            string player1Choice = Console.ReadLine();
            Console.WriteLine("Player 2 Enter 1 for Rock, 2 for Paper, 3 for Scissors, 4 for Lizard, or 5 for Spock" + "\n");
            string player2Choice = Console.ReadLine();
            winner = this.FindWinner(player1Choice, player2Choice);
            Console.WriteLine(winner);
        }
        public string FindWinner(string player1, string player2)
        {
            string win = "";
            if (player1 == player2)
            {
                win = "Its A Tie";
            }
            else if (player1 == "1")
            {
                if (player2 == "2" || player2 == "5")
                {
                    win = "Player 2 wins";
                }
                else if (player2 == "3" || player2 == "4")
                {
                    win = "Player 1 wins";
                }
                else
                {
                    win = "Player 2 made invalid input Player 1 Wins ";
                }
            }
            else if (player1 == "2")
            {
                if (player2 == "3" || player2 == "4")
                {
                    win = "Player 2 wins";
                }
                else if (player2 == "5" || player2 == "1")
                {
                    win = "Player 1 wins";
                }
                else
                {
                    win = "Player 2 made invalid input Player 1 Wins ";
                }
            }
            else if (player1 == "3")
            {
                if (player2 == "1" || player2 == "5")
                {
                    win = "Player 2 wins";
                }
                else if (player2 == "4" || player2 == "2")
                {
                    win = "Player 1 wins";
                }
                else
                {
                    win = "Player 2 made invalid input Player 1 Wins ";
                }
            }
            else if (player1 == "4")
            {
                if (player2 == "1" || player2 == "3")
                {
                    win = "Player 2 wins";
                }
                else if (player2 == "5" || player2 == "2")
                {
                    win = "Player 1 wins";
                }
                else
                {
                    win = "Player 2 made invalid input Player 1 Wins ";
                }
            }
            else if (player1 == "5")
            {
                if (player2 == "2" || player2 == "4")
                {
                    win = "Player 2 wins";
                }
                else if (player2 == "3" || player2 == "1")
                {
                    win = "Player 1 wins";
                }
                else
                {
                    win = "Player 2 made invalid input Player 1 Wins ";
                }
            }
            else
            {
                win = "player 1 made invalid input player 2 wins";
            }

            return win;
        }
    }
}
