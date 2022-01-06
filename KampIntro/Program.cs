using System;

namespace KampIntro
{

    class Program
    {

        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi= false;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalıs Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artıs Butonu");
            }
            else
            {
                Console.WriteLine("değişmediS");
            }

            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Ayarlar butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);
            
                        
        }
    }
}