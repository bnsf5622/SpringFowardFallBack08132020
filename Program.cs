using System;

namespace SpringFowardFallBack08132020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("It's Sprin...!");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + ",");
            }

            Console.WriteLine("\nOh no, it's Fall...");
            for (int i = 10;  0; i--) 
            {
                Console.Write(i + ", ");
            }
        }
    }
}