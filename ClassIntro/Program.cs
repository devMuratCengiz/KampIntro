using System;

namespace ClassIntro
{

    class Program
    {

        static void Main(string[] args)
        {
            Kurs kurs1=new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursEgitmeni = "Engin Demirog";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2=new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursEgitmeni = "Kerem Varis";
            kurs2.IzlenmeOrani = 60;

            Kurs kurs3=new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.KursEgitmeni = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 64;

            Kurs kurs4=new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.KursEgitmeni = "Murat Kurtbogan";
            kurs4.IzlenmeOrani = 100;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3,kurs4};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " " + kurs.KursEgitmeni + " " +kurs.IzlenmeOrani);
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
