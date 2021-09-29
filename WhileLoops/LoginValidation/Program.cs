using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;

           /* Console.WriteLine("sisetage kasutajatunnus");
            string username = Console.ReadLine();
            Console.WriteLine("sisestage parool");
            string Passwoerd = Console.ReadLine();*/

            while(i < 3)
            {
                Console.WriteLine("sisetage kasutajatunnus");
                string username = Console.ReadLine();
                Console.WriteLine("sisestage parool");
                string password = Console.ReadLine();

                if (username != "admin" || password != "admin1234")
                {
                    i = i + 1;
                    Console.WriteLine($"proovi uuesti. {3 - 1} katset on jäänud");
                }
                else
                {
                    Console.WriteLine("tere tulemast");
                }







            }



            
        }
    }
}
