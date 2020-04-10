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
            Console.WriteLine("васш долг - 1000 $");
            Console.Write("если хотите погасит пополните шет - ");
            int sum = Convert.ToInt32(Console.ReadLine());
            BankManager bankManager=new BankManager(sum);
            bankManager.PrintBankManager();
            Console.ReadKey();

        }
    }
}
