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
            Console.Write("Length - ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("With - ");
            int with = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            //Rectangle rectangle = new Rectangle(length,with);
            //rectangle.DrowRectangle();
            Rhombus rhombus = new Rhombus(length, with);
            rhombus.DrowRombus();
            Console.ReadKey();
        }
    }
}
