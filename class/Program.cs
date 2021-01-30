using System;

namespace class
{
    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
    }
}
}


class kurs
{
    public int MyProperty { get; set; }
}

Console.Write("[1-10] arasında sayı giriniz :");
int sayi = int.Parse(Console.ReadLine());
string cevap = "";
cevap += sayi == 7 ? "Tebrikler doğru bildiniz" : "Yanlış cevap";
Console.WriteLine(cevap);