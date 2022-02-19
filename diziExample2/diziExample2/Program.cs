using System;

namespace diziExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            //10 elemanlı bir dizi 1-200 arasında rastgele sayılar atayın
            //A-100den büyük sayıların sayısını bulun
            //B-150den küçük sayıların ortalaması
            //C-Çift sayıların sayısını bulun

            int[] sayilar = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(1, 200);
            }
            //A
            int sayac = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i]>100)
                {
                    sayac++;
                }
            }
            Console.WriteLine("Yüzden büyük sayıların sayısı {0}",sayac);
            //B
            int ortalama, toplam=0, sayacB=0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i]<150)
                {
                    toplam += sayilar[i];
                    sayacB++;
                }
            }

            ortalama = toplam / sayacB;
            Console.WriteLine("150den küçük sayıların ortalamsı:{0}",ortalama);
        }
    }
}