using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    static class Calculator
    {
        static public void Sum(double a, double b)
        {
            Console.WriteLine($"{a} + {b} = " + (a + b));
        }

        static public void Sub(double a, double b)
        {
            Console.WriteLine($"{a} - {b} = " + (a - b));
        }

        static public void Mult(double a, double b)
        {
            Console.WriteLine($"{a} * {b} = " + (a * b));
        }

        static public void Div(double a, double b)
        {
            if(b == 0) {
                Console.WriteLine("Делить на ноль нельзя!");
                return;
            }
            
            Console.WriteLine($"{a} / {b} = " + (a / b));
        }
    }
}
