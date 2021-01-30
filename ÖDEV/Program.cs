using System;

namespace ÖDEV
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("[1-10] arasında sayı giriniz :");
            int sayi = int.Parse(Console.ReadLine());
            string cevap = "";
            cevap += sayi == 7 ? "Tebrikler doğru bildiniz" : "Yanlış cevap";
            Console.WriteLine(cevap);


            rust silah1 = new rust();

            silah1.silah = "roket atar";
            silah1.malzeme = "metal boru 4 adet";
            silah1.malzeme1 = "100 adet barut";
            silah1.tasDuvar = "4 roket 16 yüksek hılı roket";


            rust silah2 = new rust();

            silah2.silah = "ak";
            silah2.malzeme = "c3";
            silah2.malzeme1 = "1000 adet barut";
            silah2.tasDuvar = "4 roket 160 yüksek hılı roket";
            
            rust silah3 = new rust();

            silah3.silah = "yarıoto";
            silah3.malzeme = "yarı oto gövde";
            silah3.malzeme1 = "12 adet barut";
            silah3.tasDuvar = "4 roket";

            rust[] rustsilah = new rust[] { silah1, silah2, silah3 };


            foreach (var silah in rustsilah)
            {
                Console.WriteLine("isim = " + silah.silah);
                Console.WriteLine("malzeme = " + silah.malzeme);
                Console.WriteLine("malzeme1 = " + silah.malzeme1);
                Console.WriteLine("taş duvarı yıkacağı = " + silah.tasDuvar);
            }
        }
    }
}
class rust
{
    public string silah { get; set; }
    public string malzeme { get; set; }
    public string malzeme1 { get; set; }
    public string tasDuvar { get; set; }
}