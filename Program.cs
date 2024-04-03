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
            Console.WriteLine("Lütfen kontrol edilecek sayıyı giriniz:");
            int sayi;

            // Kullanıcıdan sayıyı al ve doğru formatta girilene kadar tekrar iste
            while (!int.TryParse(Console.ReadLine(), out sayi) || sayi < 1)
            {
                Console.WriteLine("Geçerli bir pozitif tam sayı giriniz:");
            }

            int toplam = 0;

            // Sayının pozitif bölenlerini topla
            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    toplam += i;
                }
            }

            // Toplam sayıya eşitse mükemmel sayıdır
            if (sayi == toplam)
            {
                Console.WriteLine("{0} sayısı mükemmel bir sayıdır.", sayi);
            }
            else
            {
                Console.WriteLine("{0} sayısı mükemmel bir sayı değildir.", sayi);
            }

            Console.ReadLine();
        }
    }
}