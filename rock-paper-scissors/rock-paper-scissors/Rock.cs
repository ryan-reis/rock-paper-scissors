using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scissors
{
    public class Rock
    {
        private int number = 0;

        public int Number
        {
            get { return this.number; }
            set { this.number = value; }
        }
        public Rock(int aNumber)
        {
            this.number = aNumber;
        }
        public override string ToString()
        {
            return Number.ToString();
        }
    }
}
