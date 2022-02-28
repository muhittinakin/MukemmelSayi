using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MukemmelSayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kendisi hariç bütün pozitif çarpanları (tam bölenleri) toplamı, 
             * yine kendisine eşit olan sayılara ”mükemmel sayı” denir. 
             * Örneğin 28=1+2+4+7+14 ve 6=1+2+3   gibi. 
             * Buna göre klavyeden girilen bir tam sayının “mükemmel sayı” olup olmadığını kontrol eden
             * C# programını kodlarını yazınız */
            int sayi, toplam = 0;

         sayiGirisi:
            Console.WriteLine("Lütfen Kontrol  Edilecek Sayıyı Giriniz:");
            string okunan = Console.ReadLine();

            // string sayi dönüşüm işlemleri için
            if (!Int32.TryParse(okunan, out sayi) || sayi < 0)
            {
                Console.WriteLine("Girilen değer doğru formatta değil.Lütfen sayi giriniz...");
                goto sayiGirisi;
            }

            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    toplam += i;
                }
            }

            if (sayi == toplam)
            {
                Console.WriteLine("{0} Sayısı Mükemmel Sayıdır",sayi);
                
            }
            else
            {
                Console.WriteLine("{0} Sayısı Mükemmel Sayı Değildir", sayi);
            }

            Console.ReadLine();
        }
    }
}