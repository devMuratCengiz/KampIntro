using System;

namespace Loops
{

    class Program
    {

        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Gelistirici Yetistirme Kampi";
            string kurs2 = "Programlamaya Baslangic Icin Temel Kurs";
            string kurs3 = "Java";
            
           
            string[] kurslar =new string[] { "Yazılım Gelistirici Yetistirme Kampi",
                "Programlamaya Baslangic Icin Temel Kurs", "Java" ,"Phyton","C#"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}