using System;

namespace diziExamples
{
    class Program
    {
        static void Main(string[] args)
        {
           //Bir dizideki en küçük ve en büyük sayıları bulan kod

           int[] dizi = new int[] {2, 5, 1, 6, 20, 222, 13245, 5, 6, 9};
           int enKucuk=dizi[0],enBuyuk=dizi[0];
           for (int i = 0; i < dizi.Length; i++)
           {
               if (enKucuk>dizi[i])
               {
                   enKucuk = dizi[i];
                   
               }

               if (enBuyuk<dizi[i])
               {
                   enBuyuk = dizi[i];
               }
           }
           Console.WriteLine("{0} en büyük eleman ve {1} en küçük elemandır.",enBuyuk,enKucuk);
        }
    }
}