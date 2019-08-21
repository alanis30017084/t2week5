using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();
            c1.num1 = 2.12;
            c1.num2 = 10;
            Console.WriteLine(c1.Add());
            Console.ReadLine();
        }
    }
}
