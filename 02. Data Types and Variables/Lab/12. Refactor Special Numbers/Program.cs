using System;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int zamestitel = 0;
            bool YesOrNo = false;
            for (int i = 1; i <= num; i++)
            {
                zamestitel = i;
                while (zamestitel > 0)
                {
                    sum += zamestitel % 10;
                    zamestitel /= 10;
                }
                YesOrNo = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", i, YesOrNo);
                sum = 0;
            }
        }
    }
}
