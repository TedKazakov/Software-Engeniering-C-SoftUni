using System;

namespace _9._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int days = 0;
            int profit = 0;
            const int CREW_CONSUMES = 26;
            while (yield >= 100)
            {
                profit += yield - CREW_CONSUMES;
                yield -= 10;
                days++;
            }
            if (profit > CREW_CONSUMES)
            {
                profit -= CREW_CONSUMES;
            }
            Console.WriteLine($"{days}\n{profit}");
        }
    }
}
