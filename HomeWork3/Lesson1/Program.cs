using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrInt = new[] {10, 20, 30, 40, 50, 60};
            ArrayBack arrayBack=new ArrayBack(arrInt);
            arrayBack.Print();
            Console.ReadKey();
        }
    }
}
