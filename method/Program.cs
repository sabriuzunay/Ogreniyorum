using System;

namespace method
{
    class Program
    {
        static void Main(string[] args)
        {


            Urun ürün1 = new Urun();
            ürün1.Adı = "elma";
            ürün1.fiyat = 15;
            ürün1.Acıklama = "amasya elması";


            Urun ürün2 = new Urun();
            ürün2.Adı = "muz";
            ürün2.fiyat = 20;
            ürün2.Acıklama = "yerli muz";

            Urun ürün3 = new Urun();
            ürün3.Adı = "kavun";
            ürün3.fiyat = 72;
            ürün3.Acıklama = "Tatlı kavun";

            Urun[] urun1 = new Urun[] { ürün1, ürün2, ürün3 };

            foreach (var urun in urun1)
            {
                Console.WriteLine(urun.Adı);
                Console.WriteLine(urun.fiyat);
                Console.WriteLine(urun.Acıklama);
                Console.WriteLine("------------------------------------------");
            }

            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(ürün1);








































            Console.WriteLine("Hello World!");
        }
    }
}
