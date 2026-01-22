using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main()
        {
            SelamVer();                 // 1. Metot
            SelamVer("Sevcan");         // 2. Metot
            int sonuc = Topla(10, 20);  // 3. Metot
            Console.WriteLine("Sonuç: " + sonuc);
        }

        static void SelamVer()
        {
            Console.WriteLine("Merhaba!");
        }

        static void SelamVer(string isim)
        {
            Console.WriteLine("Merhaba " + isim + "!");
        }

        static int Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }
    }
}