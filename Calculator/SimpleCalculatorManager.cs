using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class SimpleCalculatorManager
    {
        private double num1;
        private double num2;
        private string operation;
        
        public SimpleCalculatorManager(double num1,string operation,double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.operation = operation;
        }
        private double Operation()
        {
            switch (operation)
            {
                case "+":
                    return num1 + num2;
                    break;
                case "-":
                    return num1 - num2;
                    break;
                case "*":
                    return num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                        return num1 / num2;
                    
                    break;
            }
            return 0;
           
        }
        public void PrintResult()
        {
            Console.Write($" = {Operation()}");
        }
    }
}
