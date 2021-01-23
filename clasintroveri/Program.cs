using System;

namespace clasintroveri
{
    class Program
    {
        static void Main(string[] args)
        {
          

            kurs kurs1 = new kurs();
            kurs1.Kursadi = "c#";
            kurs1.Egitmen = "engin";
            kurs1.izlenmeorani = 45;


            kurs kurs2 = new kurs();
            kurs2.Kursadi = "java";
            kurs2.Egitmen = "kerem";
            kurs2.izlenmeorani = 47;


            kurs kurs3 = new kurs();
            kurs3.Kursadi = "python";
            kurs3.Egitmen = "berkay";
            kurs3.izlenmeorani = 75;

            Console.WriteLine(kurs1.Kursadi + " : " + kurs1.Egitmen + ": " + kurs1.izlenmeorani);
            Console.WriteLine(kurs2.Kursadi + " : " + kurs2.Egitmen + ": " + kurs2.izlenmeorani);
            Console.WriteLine(kurs3.Kursadi + " : " + kurs3.Egitmen + ": " + kurs3.izlenmeorani); 
            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.Kursadi + " : " + kurs.Egitmen + " : " + kurs.izlenmeorani);
            }



           //Console.WriteLine("Hello World!");
        }
    }

    class kurs
    {
        public string Kursadi { get; set; }
        public string Egitmen { get; set; }
        public int izlenmeorani { get; set; }
    }

}
