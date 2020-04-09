using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("pleas write operad1-");
            int oprade1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("pleas write sign -");
            string sign = Console.ReadLine();
            Console.Write("pleas write operad2-");
            int oprade2 = Convert.ToInt32(Console.ReadLine());
            Calculate calculate = new Calculate(oprade1, sign, oprade2);
            decimal res = calculate.Calculating();
            Console.WriteLine(res);
            Console.ReadKey();


        }
    }
}
