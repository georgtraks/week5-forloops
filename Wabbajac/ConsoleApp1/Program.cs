using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            double firstnumber;
            double secondnumber;
            double answer;
            string ops;

            Console.WriteLine("\t\t\tCalculator in C#\r");
            Console.WriteLine("\t\t\t-------------------------------------\r");

            Console.WriteLine("\t\t\tEnter first number\n");
            firstnumber = Double.Parse(Console.ReadLine());


            Console.WriteLine("\t\t\tEnter Operator: (+, -, *, /, %, ^)\n");
            ops = Console.ReadLine();

            Console.WriteLine("\t\t\tEnter second number\n");
            secondnumber = Double.Parse(Console.ReadLine());

            Console.WriteLine("\n");

            if (ops == "+")
            {
                answer = firstnumber + secondnumber;
                Console.Write(answer);
            }
            if (ops == "-")
            {
                answer = firstnumber - secondnumber;
                Console.Write(answer);
            }
            if (ops == "*")
            {
                answer = firstnumber * secondnumber;
                Console.Write(answer);
            }
            if (ops == "/")
            {
                answer = firstnumber / secondnumber;
                Console.Write(answer);
            }
            if (ops == "%")
            {
                answer = firstnumber % secondnumber;
                Console.Write(answer);
            }

            Console.WriteLine("\n");

            Console.Write("\n" + "Press the any key to yeet...");
            Console.ReadKey();
        }
    }
}
