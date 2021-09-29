using System;

namespace multiplicationtable
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada numbrit;
            //programm kuvab korrutustabelit 1 kuni 10 sisestatud numbri jaoks
            // usernumber = 5
            //1 * 5 = 5;
            //2 * 5 = 10;
            //jne

            Console.WriteLine("sisesta nuber:");
            int usernumber = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{i} * {usernumber} = {i*usernumber}");
            }


        }
    }
}
