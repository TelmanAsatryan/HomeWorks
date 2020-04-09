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
            Console.Write("pleas write word(жывотное,самалет,сигарет,кот,собака) - ");
            string word = Console.ReadLine();
            Librery librery=new Librery(word);
            librery.Translate();
            Console.ReadKey();
        }
    }
}
