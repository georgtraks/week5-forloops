using System;

namespace calculatingsum
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kolm arvu;
            //programm kuvab nende arvude summat






            int sum = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("sisesta number:");
                int usernumber = Convert.ToInt32(Console.ReadLine());
                sum = sum + usernumber;
            }

            Console.WriteLine($"your result is {sum}.");
        }
    }
}
