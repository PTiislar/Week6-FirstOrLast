using System;

namespace HOL_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu 'h', 'o' ja 'i' tähte on lauses "Hello World!"

            string helloW = "Hello World";

            string helloWLow = helloW.ToLower();

            int stringLenght = helloWLow.Length;

            int hCounter = 0;
            int oCOunter = 0;
            int lCounter = 0;

            for (int i = 0; i < helloWLow.Length; i++)
            {
                if (helloWLow[i] == 'h')
                {
                    hCounter++;
                }
                else if (helloWLow[i] == 'o')
                {
                    oCOunter++;
                }
                else if (helloWLow[i] == 'l')
                {
                    lCounter++;
                }
            }
            Console.WriteLine($"Lauses 'Hello World!' on {hCounter} h-t, {oCOunter} o-t, {lCounter} l-i."); ");

        }
    }
}
