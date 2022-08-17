using System;

namespace _8._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nKregs = int.Parse(Console.ReadLine());                
            string maxVolumeName = "";                
            double maxVolum = 0;
            for (int i = 0; i < nKregs; i++)
            {
                string typeOfKreg = Console.ReadLine();    
                
                double radius = double.Parse(Console.ReadLine());
                
                uint hight = uint.Parse(Console.ReadLine());
                
                
                double volume = Math.Pow(radius, 2) * Math.PI * hight;            
                
                if (maxVolum < volume)
                {
                    maxVolum = volume;
                    maxVolumeName = typeOfKreg;
                }
            }
            Console.WriteLine(maxVolumeName);

        }
    }
}
