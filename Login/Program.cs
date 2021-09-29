using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisestage kasutajatunnus.");
            string username = Console.ReadLine();
            Console.WriteLine("sisesta parool.");
            string userpassword = Console.ReadLine();

            if (username != "admin" || userpassword != "admin1234" )
            {
                Console.WriteLine("siselogimine ebaõnnestus. proovi uuesti.");
            }
            else
            {
                Console.WriteLine("tere tulemast!");
            }
        }
    }
}
