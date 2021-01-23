using System;

namespace ödev1
{
    class product
    {
        static void Main(string[] args)
        {
            product  urunler1 = new product();
            urunler1.UrunAdi = "mont";
            urunler1.Satici = "nike";
            urunler1.Fiyati = 9999;

            product product2 = new product();
            product2.UrunAdi = "Damatlık";
            product2.Satici = "Kiğılı";
            product2.Fiyati = 9999;

            product product3 = new product();
            product3.UrunAdi = "Jean";
            product3.Satici = "mavi";
            product3.Fiyati = 9999;


            product[] Urunler = new product[] { urunler1, product2, product3 };
            Console.WriteLine(urunler1.UrunAdi + ":" + urunler1.Satici + ":" + urunler1.Fiyati);



        }
    }    public string UrunAdi { get; private set; }
         public string Satici { get; private set; }
         public string Fiyati { get; private set; }
}
