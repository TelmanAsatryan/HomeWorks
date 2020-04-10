using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class BankManager
    {
        private int sum;
        public BankManager(int sum)
        {
            this.sum = sum;
        }

        private void MonyChekZero()
        {
            
                Console.WriteLine("на вашем шето -1000$");
        }

        private void MonyChak()
        {
            int chak;

            Console.WriteLine($"ваш шет попалнилос {sum} ");
            chak = 1000 - sum;
            Console.WriteLine($"тепер у вас долг {chak}");

        }
        private void ChakOllMony()
        {
            Console.WriteLine("ваш долг погасен ");
            Console.WriteLine("на вашем шету 0$");
        }

        private void ChakMuchMony()
        {
            int chak;
            chak = sum - 1000;
            Console.WriteLine($"на вашем шету {chak}$");
        }

        public void PrintBankManager()
        {
            if(sum==0)
                MonyChekZero();
            if(sum<1000)
                MonyChak();
            if(sum==1000)
                ChakOllMony();
            if(sum>1000)
                ChakMuchMony();
        }
    }



}
