using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //string[] sehir = { "Ankara", "İstanbul", "İzmir", "Adana" };
            //foreach (string i in sehir)
            //{
            //                    Console.WriteLine(i);
            //}
            #endregion
            #region
            //int[] sayilar= { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int enBuyuk = sayilar [0];

            //foreach (int sayi in sayilar)
            //{
            //    if (sayi > enBuyuk)
            //    {
            //        enBuyuk = sayi;
            //    }
            //}
            //Console.WriteLine("En büyük sayı: " + enBuyuk);
            #endregion
            #region
            //int[] sayilar = { 3, 7, 3, 2, 9, 3, 5, 7 };
            //int aranan = 3;
            //int sayac = 0;
            //foreach (int sayi in sayilar)
            //{
            //    if (sayi == aranan)
            //    {
            //        sayac++;
            //    }
            //}
            //Console.WriteLine($"{aranan} sayısı dizide {sayac} kere geçiyor.");
            #endregion

            #region
            int [] notlar = { 75, 60, 90, 45, 80 };
            int toplam = 0;
            foreach (int not in notlar)
            {
                toplam += not;
            }
            double ortalama = (double)toplam / notlar.Length;
                        Console.WriteLine($"Notların ortalaması: {ortalama}" );
            if (ortalama >= 50)
            {
                Console.WriteLine("Geçti");
            }
            else
            {
                Console.WriteLine("Kaldı");
            }
            #endregion
        }
    }
}
