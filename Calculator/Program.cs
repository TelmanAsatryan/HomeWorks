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
            
            Console.WriteLine("pleas select what you whant to do");
            Console.WriteLine(" 1 -  Simple Calculation  (+ , - , * , / ) ");
            Console.WriteLine(" 2 -  Increase degree  ( (x)y, ) ");
            int select = Convert.ToInt32(Console.ReadLine());
            switch(select)
            {
                case 1:
                    SimpleCalculation();
                    break;
                case 2:
                    IncreaseDegree();
                    break;

            }
            Console.ReadKey();
        }
        static void SimpleCalculation()
        {
            Console.Write("write your number- ");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("write your operation- ");
            string operation = Console.ReadLine();
            Console.Write("write anther number- ");
            double num2 = Convert.ToInt32(Console.ReadLine());
            SimpleCalculatorManager calculator = new SimpleCalculatorManager(num1, operation, num2);
            calculator.PrintResult();   
        }
        static void IncreaseDegree()
        {
            Console.Write("write your number- ");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("now write how you whant Increase Degree");
           int num2 = Convert.ToInt32(Console.ReadLine());
            IncreaseDegreeManager increaseDegree = new IncreaseDegreeManager(num1, num2);
            increaseDegree.PrintResult();
        }
    }
}
