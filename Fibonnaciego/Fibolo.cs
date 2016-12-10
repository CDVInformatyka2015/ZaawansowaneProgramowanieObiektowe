using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonnaciego
{
    class Fibolo
    {
        public Fibolo(int n1, int n2)
        {
            Number1 = n1;
            Number2 = n2;
        }

        public int Number1 { get; set; }
        public int Number2 { get; set; }

        public int getResult()
        {
            return Number1 + Number2;
        }

        public int getReverseResult()
        {
            return Number2 - Number1;
        }

        public void Calculate()
        {
            var temp = getResult();
            Number1 = Number2;
            Number2 = temp;
        }

        public void ReverseCalculate()
        {
            var temp = getReverseResult();
            Number2 = Number1;
            Number1 = temp;
        }
    }
}
