using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class ArrayManager
    {
        private int[] arr;
        public ArrayManager(int [] arr)
        {
            this.arr = arr;
        }

        private void ArrayMax()
        {
            Console.WriteLine($"Array Max-{arr.Max()}");        
        }

        private void ArrayMin()
        {
            Console.WriteLine($"array Min {arr.Min()}");
        }

        private void ArraySum()
        {
            int sumOfArrNums = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sumOfArrNums = sumOfArrNums + arr[i];
            }

            Console.WriteLine($"thats your Array Sum{sumOfArrNums}");
        }

        private void ArrayFinder()
        {
            for (int i = 0; i < arr.Length; i++)
            { 
                if(arr[i]%2!=0)
                    Console.WriteLine($"Array Finder - {arr[i]}");
            }
        }

        public void PrintRes()
        {
            ArrayMax();
            ArrayMin();
            ArraySum();
            ArrayFinder();
        }
    }
}
