using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Calculator
    {
        private double num1;
        private double num2;
        private string calc;
        public Calculator(double num1, double num2,string calc)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.calc = calc;
        }

        private double Add()
        {
            return num1 + num2;
        }

        private double Sub()
        {
            return num1 - num2;
        }

        private double Mul()
        {
            return num1 * num2;
        }

        private double Div()
        {
            double res;
            if (num2 != 0)
            {
                res= num1 / num2;
                return res;
            }
            else
            {
                return 0;
            }
        }

        public void PrintResult()
        {
            if (calc == "+")
            {
                Console.WriteLine(Add());
            }
            if (calc == "-")
            {
                Console.WriteLine(Sub());
            }
            if (calc == "*")
            {
                Console.WriteLine(Mul());
            }
            if (calc == "/")
            {
                Console.WriteLine(Div());
            }
        }
    }
}
