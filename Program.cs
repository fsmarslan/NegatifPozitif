using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegatifPozitif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char secim;
            do
            {
                int negatifSayi = 0, pozitifSayi = 0, sifirSayisi = 0;
                int[] sayilar = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Lütfen {0}. sayıyı giriniz.", i + 1);
                    sayilar[i] = Convert.ToInt32(Console.ReadLine());
                }
                foreach (var sayi in sayilar)
                {
                    if (sayi < 0)
                        negatifSayi++;
                    else if (sayi > 0)
                        pozitifSayi++;
                    else
                        sifirSayisi++;
                }
                Console.WriteLine("Negatif sayı adedi: {0}\nPozitif sayı adedi: {1}\nSıfır sayısı adedi: {2}", negatifSayi, pozitifSayi, sifirSayisi);

                Console.WriteLine("Tekrar yapmak ister misiniz? (e/h) ");
                secim = Convert.ToChar(Console.ReadLine());
                if (secim == 'e')
                    Console.Clear();
                else if (secim == 'h')
                    Console.Clear();
            } while (secim == 'e');
            Console.WriteLine("Uygulamayı kullandığınız için teşekkürler.");
            Console.WriteLine("İşlem bitmiştir...");
            Console.ReadKey();
        }
    }
}
