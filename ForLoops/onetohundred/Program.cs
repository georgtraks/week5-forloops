using System;

namespace onetohundred
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100000000; i++)
            {
                Console.WriteLine($"{i + 1}");
            }

        }
    }
}
