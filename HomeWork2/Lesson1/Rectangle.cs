using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Rectangle
    {
        private int length;
        private int whith;
        public Rectangle(int length,int whith)
        {
            this.length = length;
            this.whith = whith;
        }

        public void DrowRectangle()
        {
            for (int i = 0; i < whith; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write(" * ");
                }

                Console.WriteLine();
            }
        }
    }
}
