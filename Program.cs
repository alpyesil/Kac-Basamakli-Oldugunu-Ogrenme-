using System;

namespace Kaç_basamaklı
{
    class Program
    {
        static void Main(string[] args)
        {
            int sonuc = 0;
            int toplam = 0;
            Console.Write("Sayı Girin : ");
            int sayi = int.Parse(Console.ReadLine());
            while (sayi > 0)
            {
                toplam = (sayi % 10);
                sonuc = toplam + sayi;
                
                //sayi = sayi / 10;
            }
            Console.WriteLine("Girdiğiniz Sayının Rakamları Toplamı : " + sonuc);
            Console.ReadKey();


        }
    }
}
