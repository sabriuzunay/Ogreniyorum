using System;

namespace devam
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i+=2)
            {
                Console.WriteLine(i);
            }


            String[] isimler = new string[] { "sabri", "burak", "tunahan", "yalçın", "çeğler" };

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);
            }


            foreach (string s in isimler)
            {
                Console.WriteLine(s);
            }
























        }
    }
}
