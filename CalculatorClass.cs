using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment20Day15
{
    public class CalculatorClass
    {
        public void Addition(int num1,int num2)
        {
            int result = num1 + num2;
            Console.WriteLine($"Addtion of two number {num1} and {num2} is:  "+result);
        }

        public void Subtraction(int num1,int num2)
        {
            int resuklt = num1 - num2;
            Console.WriteLine($"Subtraction of two Numbers {num1} and {num2} is:  "+resuklt);
        }

        public void Multiple(int num1,int num2)
        {
            int result = num1 * num2;
            Console.WriteLine($"Mutplication of two number {num1} and {num2} is:  "+result);
        }
        public void Divide(int num1,int num2)
        {
            double result = num1 / num2;
            Console.WriteLine($"Division of two number is {num1} and {num2} is:  "+result);
        }
    }
}
