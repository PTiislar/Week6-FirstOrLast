using System;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab kasutaja eesnime tagurpid

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();

            for (int i = firstName.Length - 1; i>= 0; i--)
            {
                Console.WriteLine(firstName[i]);
            }
         }
    }
}
