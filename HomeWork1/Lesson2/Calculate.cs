using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Calculate
    {
        private int operand1;
        private int operand2;
        private string sign;
        public Calculate(int operand1, string sing, int operand2)
        {
            this.operand1 = operand1;
            this.operand2 = operand2;
            this.sign = sing;
        }

        public decimal Calculating()
        {
            decimal res;
            if (sign == "+" || sign == "-" || sign == "/" || sign == "*")
            {
                switch (sign)
                {
                    case "+":
                        {
                            res = operand1 + operand2;
                            return res;
                            break;
                        }
                    case "-":
                        {
                            res = operand1 - operand2;
                            return res;

                            break;
                        }
                    case "/":
                        {
                            res = operand1 / operand2;
                            return res;

                            break;
                        }
                    case "*":
                        {
                            res = operand1 * operand2;
                            return res;

                            break;
                        }
                }
            }
            else
            {
                return 0;
            }

            return 0;
        }
    }
}
