using System;

namespace diziExample3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Girilen kelimeyi harf harf alt alta yazdıran kodu yazın.
            /*Console.WriteLine("bir metin giriniz");
            string giris = Console.ReadLine();
            foreach (char karakter in giris)
            {
                Console.WriteLine(karakter);
                
            }*/
            Console.WriteLine("bir metin giriniz");
            string metin = Console.ReadLine();
            for (int i = metin.Length-1; i >= 0; i--)
            {
                Console.Write(metin[i]);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}