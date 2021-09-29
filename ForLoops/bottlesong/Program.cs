using System;

namespace bottlesong
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100000000; i > 0; i--)
            {
                Console.WriteLine($"{i} bottles of beer on the wall, {i} bottles of beer. take one down and passi around, {i - 1} bottles of beer on the wall");

                if (i == 0)
                {
                    Console.WriteLine("no more bottles of beer on the wall, no more bottles of beer.");
                }
                    
                
            }
           




        }
    }
}
