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

            

            Console.WriteLine("Enter Rock,Paper,Scissors,Lizard, or Spock"+"\n");
            string playerChoice = Console.ReadLine();
            
        }
    }
}
