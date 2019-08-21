using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calc
    {
        public double num1 { get; set; }
        public double num2 { get; set; }

        public double Add()
        {
            return num1 + num2;
        }
        public double Subr()
        {
            return num1 - num2;
        }
        public double Multi()
        {
            return num1 * num2;
        }
        public double Divide()
        {
            return num1 / num2;
        }
    }
}
