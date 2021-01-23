using System;

namespace kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] {"yazılım geliştirme kursu" , 
                "programcı kampı" , "java" };








            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }
            
            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }



            Console.WriteLine("sayfa sonu - footer");








            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Açiklama = "amasya";

            Urun[] urunler = new Urun[] { urun1 };











        }




    }
}







