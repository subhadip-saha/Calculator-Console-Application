using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            char op;
            double num1, num2;

            Console.WriteLine("==============Enter the Operator(+, -, *, /)===============");
            op = Console.ReadLine()[0];

            Console.WriteLine();

            Console.WriteLine("===========Enter the two numbers one by one for which you want to do operation==========");
            Console.WriteLine("Enter the first number");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            num2 = Convert.ToDouble(Console.ReadLine());


            switch(op)
            {
                case '+':
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1 + num2));
                    break;

                case '-':
                    Console.WriteLine("{0} - {1} = {2}", num1, num2, (num1 - num2));
                    break;

                case '*':
                    Console.WriteLine("{0} * {1} = {2}", num1, num2, (num1 * num2));
                    break;

                case '/':
                    if (num2 == 0.0)
                        Console.WriteLine("Divide by zero situation");
                    else
                        Console.WriteLine("{0} / {1} = {2}", num1, num2, (num1 / num2));
                    break;

                default:
                    Console.WriteLine("{0} is an invalid operator", op);
                    break;
            }

            Console.WriteLine("Press Any Key to Exit the Program");
            Console.ReadKey();
        }
    }
}
