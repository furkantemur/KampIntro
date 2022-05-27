using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 20;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------");

            }

            Console.WriteLine("----------Metotlar-----------");

            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            //kullanmamaya özen göster üstteki daha kalıcı çözüm.
            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,3);
            sepetManager.Ekle2("Elma", "Yeşil Armut", 12,8);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12,7);


        }
    }
}
