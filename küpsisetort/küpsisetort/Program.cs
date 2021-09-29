using System;

namespace küpsisetort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many cookies wide is the cake?");
            int CWide = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("how many cookies in lenght is the cake?");
            int CLong = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("how manylayers does the cake have?");
            int CLayer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("how many cookies in a pack of cookies?");
            int CPack = Convert.ToInt32(Console.ReadLine());
            int CArea = CLong * CWide;
            int CALL = CLayer * CArea;
            int CPALL = Convert.ToInt32(Math.Round((double)CALL / CPack));
            Console.WriteLine($"you need {CPALL} packs of cookies");











        }
    }
}
