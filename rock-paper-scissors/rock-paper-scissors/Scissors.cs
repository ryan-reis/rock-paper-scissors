//Written by Zachary Skinner and Ryan
//3/1/2023
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scissors
{
    public class Scissors
    {
        private int number = 0;

        public int Number
        {
            get { return this.number; }
            set { this.number = value; }
        }
        public Scissors(int aNumber)
        {
            this.number = aNumber;
        }
        public override string ToString()
        {
            return Number.ToString();
        }
    }
}
