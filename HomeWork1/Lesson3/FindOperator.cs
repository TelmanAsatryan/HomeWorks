using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class FindOperator
    {
        private int num;
        public FindOperator(int num)
        {
            this.num = num;
        }

        public void Finder()
        {
            if (num >= 0 && num <= 14)
                Console.WriteLine("your number in [0-14]");
            else if (num >= 15 && num <= 35)
                Console.WriteLine("your number in [15-35]");
            else if (num >= 36 && num <= 50)
                Console.WriteLine("your number in [16-50]");
            else if (num>=51&&num<=100)
                Console.WriteLine("tour number in [51-100] ");
            else if (num>=101)
                Console.WriteLine("pleas select your number in [0-100]");
            
        }
    }
}
