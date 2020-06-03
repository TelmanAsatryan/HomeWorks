using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class IncreaseDegreeManager
    {
        private double num1;
        private int num2;
        public IncreaseDegreeManager(double num1,int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        private double Calculation()
        {
            if (num2 != 0)
            {
                double res = num1;
                for (int a = 1; a < num2; a++)
                {
                    res *= num1;
                }
                return res;
            }
            else
                return 1;
            
        }
        public void PrintResult()
        {
            Console.WriteLine($" =  {Calculation()}");
        }
    }
}
