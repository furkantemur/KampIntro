using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Furkan";
            int yas = 25;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = " C#";
            kurs1.Egitmen = "Furkan Temur";
            kurs1.IzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = " Java";
            kurs2.Egitmen = " Mehmet Furkan Temur";
            kurs2.IzlenmeOranı = 58;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "MFTemur";
            kurs3.IzlenmeOranı = 48;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "MFT";
            kurs4.IzlenmeOranı = 38;



            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen );

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen + " : " + kurs.IzlenmeOranı );
               
            }
        }
    }
   
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public  int  IzlenmeOranı { get; set; }
    }
}
