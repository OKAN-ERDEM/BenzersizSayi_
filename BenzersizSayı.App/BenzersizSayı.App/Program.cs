using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenzersizSayı.App
{
    class Program
    {
        static void Main(string[] args)
        {//193801025 Okan ERDEM 


            Console.WriteLine("Kaç adet sayı üretelim? :");
            int adet = int.Parse(Console.ReadLine());
            int[] sayilar = new int[adet];


            Random rnd = new Random();

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(0,100);
                for (int kontrol = 0; kontrol < i; kontrol++)
                {
                    if (sayilar[kontrol] == sayilar[i])
                    {
                        i--;
                        break;
                    }
                }
            }

            Console.WriteLine("Sayılarınız:");

            Array.Sort(sayilar);
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write($"{sayilar[i]} ");
            }

            Console.ReadKey();
        }
    }
}
