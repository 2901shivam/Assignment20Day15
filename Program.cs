using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Assignment20Day15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the appropiate option for Desired result : 1.Hello World \n 2.Variable and UserInput \n 3.Basic Arithematic \n 4. Control structure \n 5.Loops \n 6.Arrays \n 7.Methods \n 8.Exception Handeling");
            Console.WriteLine("Enter the number for execuation");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    {
                        Console.WriteLine("Hello World");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter Your Name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Hello,"+name);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Calculator");
                        Console.WriteLine("Enter the first number");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the second Number");
                        int num2 = int.Parse(Console.ReadLine());
                        CalculatorClass cl = new CalculatorClass();
                        Console.WriteLine("Calculator Enter 1.Addition 2.Subtraction 3.MultiPlication 4.Modulus");
                        int option = int.Parse(Console.ReadLine());
                        
                        switch (option)
                        {
                            case 1:
                                {
                                    cl.Addition(num1, num2);
                                    break;
                                }
                            case 2:
                                {
                                    cl.Subtraction(num1, num2);
                                    break;
                                }
                            case 3:
                                {
                                    cl.Multiple(num1, num2);
                                    break;
                                }
                            case 4:
                                {
                                    cl.Divide(num1, num2);
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Invalid Operation");
                                    break;
                                }
                        }
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Check given number is even or odd");
                        Console.WriteLine("Enter the number");
                        int num = int.Parse(Console.ReadLine());

                        if (num % 2 == 0)
                        {
                            Console.WriteLine($"Enter number {num} is an even ");
                        }
                        else
                        {
                            Console.WriteLine($"Enter number {num} is an odd");
                        }

                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Print the number from 1 to 10");
                        for(int i = 0; i < 10; i++)
                        {
                            Console.WriteLine(i);
                        }
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Operation on the array");
                        Console.WriteLine("Enter the size of the array");
                        int n = int.Parse(Console.ReadLine());
                        int[] arr = new int[n];
                        Console.WriteLine("Enter the number which u want to insert in the array");

                        for(int i = 0; i < arr.Length; i++)
                        {
                            arr[i] = int.Parse(Console.ReadLine());
                        }
                        ArrayClass ar = new ArrayClass();
                        Console.WriteLine("Choose the option for appropiate result 1.Sum in array 2.Average of element in the array");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                {
                                    ar.Sum(arr);

                                    break;
                                }
                            case 2:
                                {
                                    ar.Avg(arr);
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Invalid option");
                                    break;
                                }
                        }
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Method to calculate the factorial");
                        Console.WriteLine("Enter the number");
                        int number = int.Parse(Console.ReadLine());
                        FactorialClass fact = new FactorialClass();
                        double result = fact.factoral(number);
                        Console.WriteLine($"Factorial of entered number {number} is: "+result);
                        break;
                    }
                case 8:
                    {
                        ExceptionHandeling ex = new ExceptionHandeling();
                        ex.EnterAge();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
    }
}
