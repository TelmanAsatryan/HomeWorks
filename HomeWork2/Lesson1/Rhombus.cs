using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Rhombus
    {
        private int length;
        private int width;
        public Rhombus(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public void DrowRombus()
        {
            for (int i = 0; i <width/2; i++)
            {
                for (int j = i; j<length/2; j++)
                {
                    Console.Write("#");
                }
                for (int j = i; j <length/2; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
