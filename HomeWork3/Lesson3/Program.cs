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
            Console.WriteLine("select your array langht");
            int arrLangth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"now select your nums in array - {arrLangth} - ");
            int[] arr = new int[arrLangth];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("write your element  - ");
            int num = Convert.ToInt32(Console.ReadLine());
            ArrayManager arrayManager=new ArrayManager(arr,num);
            arrayManager.PrintRes();
            Console.ReadKey();
        }
    }
}
