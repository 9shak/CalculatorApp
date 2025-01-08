using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            Console.WriteLine();
            Console.WriteLine("Select an operation: Addition, Subtraction, Multiplication, Division");
            Console.WriteLine();
            string operation = Console.ReadLine();

            Console.WriteLine("Enter first number:");
            Console.WriteLine();
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            Console.WriteLine();
            double number2 = Convert.ToDouble(Console.ReadLine());

            double answer = 0;

            switch (operation)
            {
                case "Addition":
                    answer = Add(number1, number2);
                    break;

                case "Subtraction":
                    answer = Subtract(number1, number2);
                    break;

                case "Multiplication":
                    answer = Multiply(number1, number2);
                    break;

                case "Division":
                    answer = Divide(number1, number2);
                    break;


                default:
                    Console.WriteLine("Operation Unavailable");
                    Console.ReadKey();
                    return;

            }

            Console.WriteLine();
            Console.WriteLine($"Result: {answer}");
            Console.ReadKey();

        }


        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is unavailable.");
               
            }
            return a / b;



        }

      
        

    }
}
