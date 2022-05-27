using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1 , int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç : "+ toplam);
        }
        public void Cıkart(int sayi1, int sayi2)
        {
            int cıkart = sayi1 - sayi2;
            Console.WriteLine("Sonuç : " + cıkart);
        }
    }
}
