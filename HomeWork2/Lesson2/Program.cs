using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("pleas select number one - ");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("pleas select Calc - ");
            string calc = Console.ReadLine();
            Console.Write("pleas write number tow - ");
            double num2 = Convert.ToInt32(Console.ReadLine());
            Calculator calculator=new Calculator(num1,num2,calc);
            calculator.PrintResult();
            
            Console.ReadKey();

        }
    }
}
