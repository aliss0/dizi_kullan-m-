using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizi_kullanımı
{
    class Program
    {
        static void Main(string[] args)
        {
            // dizi tanımlama 
            string[] renkler = new string[5];

            string[] hayvanlar = { "kedi", "kuş", "maymun", "köpek" };
            int[] dizi;
            dizi = new int[5];

            // atamaları
            renkler[0]= "mavi";
            Console.WriteLine(hayvanlar[1]);
            dizi[3] = 10;
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);
            Console.WriteLine("----------------------------------");

            // dizilerle döngüler

            Console.Write("Lütfen Bir Sayı Giriniz : ");

            int diziuzunluk = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------");

            int[] sayidizi = new int[diziuzunluk];
            for (int i =0; i< diziuzunluk;i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz : ", i + 1);
                sayidizi[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;
            foreach (var sayi in sayidizi)
            {
                toplam += sayi;
            }
            Console.Write("Ortalama:  " + toplam / diziuzunluk);


            Console.ReadLine();
        }
        
    }
}
