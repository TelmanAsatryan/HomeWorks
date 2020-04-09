using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Librery
    {
        private string word;
        public Librery(string word)
        {
            this.word = word;
        }

        public void Translate()
        {

            switch (word)
            {
                case "жывотное":
                {
                    Console.WriteLine("animale");
                    
                    break; 

                }
                case "самалет":
                {
                    Console.WriteLine("plane"); 
                    break;

                }
                case "сигарет":
                {
                    Console.WriteLine("sigaret"); 
                    break;

                }
                case "кот":
                {
                    Console.WriteLine("cat"); 
                    break;

                }
                case "собака":
                {
                    Console.WriteLine("dog");
                    break;

                }
                case "":
                {
                    Console.WriteLine("you not write nothing"); 
                    break;
                }
            }
        }
    }
}
