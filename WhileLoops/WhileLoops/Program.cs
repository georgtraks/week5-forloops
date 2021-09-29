using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajalt sisestada pin-koodi;
            //programm vordleb sisestatud pin-koodi arvuga 1234;
            //kui sisestatud pin-kood on 1234, siis konsool kuvab "Tere Tulemst!"
            //kui sisestatud pin-kood on midagi muud, konsool kuvab "Vale pin. proovi uuesti."
            //kasutajal on kolm katset
            //tingimus 1. katsete arv on piiramatu
            //tingimus 2. kasutajal on kolm katset


            //boolean = true/false




            /*
             int i = 0;



             while(i < 3)
             {
                 Console.WriteLine("sisesta pin-kood");
                 int userpin = Convert.ToInt32(Console.ReadLine());

                 if(userpin == 1234)
                 {
                     Console.WriteLine("tere tulemast!");
                     break;
                 }
                 else
                 {
                     Console.WriteLine("vale pin proovi uuesti.");
                 }


             }*/


            int i = 0;
            while(i < 3)
            {
                Console.WriteLine("sisesta pin-kood");
                int userpin = Convert.ToInt32(Console.ReadLine());


                if(userpin == 1234)
                {
                    Console.WriteLine("Tere Tulemast!");
                    break;
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"vale pin. {3 - i} katset on jäänud.");
                }


            }





            Console.WriteLine("kena päeva!");
           
           




        }
    }
}
