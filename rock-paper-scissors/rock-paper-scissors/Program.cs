//Written by Zachary Skinner and Ryan
//3/1/2023
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scissors
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Rock aRock = new Rock(1);
            Paper aPaper = new Paper(2);
            Scissors aScissors = new Scissors(3);
            Lizard aLizard = new Lizard(4);
            Spock aSpock = new Spock(5);
            GameManager manager = new GameManager();
            manager.PlayRockPaperScissors();
            bool wantToPlay = true;
            string playerChoice = "";
            while (wantToPlay == true)
            {
                Console.WriteLine("do you want to keep playing rock paper sisszors spock lizard? if yes type: 1 if no type: 2 ");
                playerChoice = Console.ReadLine();
                if (playerChoice == "1")
                {
                    manager.PlayRockPaperScissors();
                }
                else
                {
                    wantToPlay = false;
                }
            }

            Console.ReadLine();
        }
    }
}
