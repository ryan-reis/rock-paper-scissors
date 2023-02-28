using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scissors
{
    public class Lizard
    {
        private int number = 0;

        public int Number
        {
            get { return this.number; }
            set { this.number = value; }
        }
        public Lizard(int aNumber)
        {
            this.number = aNumber;
        } 
        public override string ToString()
        {
            return number.ToString();
        }
    }
}
