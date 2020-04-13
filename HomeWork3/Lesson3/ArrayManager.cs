using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class ArrayManager
    {
        private int[] arr;
        private int[] newArr;
        private int num;

        public ArrayManager(int [] arr,int num)
        {
            this.arr = arr;
            this.num = num;
        }

        private void AddArrayNum()
        {
            int[] newArr=new int[arr.Length+1];
            for (int i = 1; i < newArr.Length; i++)
            {
                newArr[i] = arr[i - 1];
            }

            newArr[0] = num;
        }

        public void PrintRes()
        {
            AddArrayNum();
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.WriteLine($"thats your Array Element - {newArr[i]}");
            }
        }
    }
}
