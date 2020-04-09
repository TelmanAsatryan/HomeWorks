using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("pleas select number for [0-100] - ");
            int num = Convert.ToInt32(Console.ReadLine());
            FindOperator find=new FindOperator(num);
            find.Finder();
            Console.ReadKey();
        }
    }
}
