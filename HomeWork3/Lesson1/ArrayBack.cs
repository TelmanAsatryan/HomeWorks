using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class ArrayBack
    {
        private int[] arr;
        private int[] arrBack ;
        public ArrayBack(int [] arr)
        {
            this.arr = arr;
        }

        private void Back()
        {
            arrBack = new int[arr.Length];
            int next = 0;
            
            for (int i = arr.Length-1; i >=0; i--)
            {

                arrBack[i] = arr[i];
                next++;
            }

          
        }

        public void Print()
        {
            Back();
            for (int i = 0; i < arrBack.Length; i++)
            {
                Console.WriteLine(arrBack[i]);
            }
        }
    }
}
