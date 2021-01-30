using System;

namespace GenericksIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            
            
            MyList<string> Names = new MyList<string>();

            Names.Add("Sabri");
            Console.WriteLine(Names);
        }
    }
}
