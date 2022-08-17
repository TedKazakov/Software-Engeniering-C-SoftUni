using System;
using System.Text;

namespace _7.__String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string explosions = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(explosions);
            int remainingPower = 0;
            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == '>')
                {
                    int strength = int.Parse(sb[i + 1].ToString()) + remainingPower;
                    for (int u = 0; u < strength; u++)
                    {
                        if (i + 1 >= sb.Length) break;
                        if (sb[i + 1] == '>')
                        {
                            remainingPower += strength - u;
                            break;
                        }
                        sb.Remove(i + 1, 1);
                        remainingPower = 0;
                    }
                }
            }
            Console.WriteLine(sb);
        }
    }
}
