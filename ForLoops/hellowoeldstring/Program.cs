using System;

namespace hellowoeldstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloworld = "hello world!";

            for(int i = 0; i < helloworld.Length; i++ )
            {
                Console.WriteLine($"kohal {i} on {helloworld[i]} ");
            }


        }
    }
}
