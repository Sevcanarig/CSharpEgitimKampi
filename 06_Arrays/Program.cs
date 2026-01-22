using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 5, 9, 2, 7, 3 };
            int enBuyuk = sayilar[0];

            for (int i = 1; i < sayilar.Length; i++)
            {
                if (sayilar[i] > enBuyuk)
                    enBuyuk = sayilar[i];
            }

            Console.WriteLine("En büyük sayı: " + enBuyuk);

        }
    }
}
