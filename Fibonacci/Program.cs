using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            // To set input
            long NthNumber = 50;
            long EndNumber = NthNumber - 1;
            long[] ArrVar = new long[NthNumber];
            ArrVar[0] = 0;
            ArrVar[1] = 1;
            for (int i = 2; i <= EndNumber; i++)
            {
                ArrVar[i] = ArrVar[i - 2] + ArrVar[i - 1];
            }
            Console.WriteLine(NthNumber + "th Fibonacci is: " + ArrVar[EndNumber]);
            //to hold screen
            Console.ReadKey();
        }
    }
}
