using System;
using OOPconsole;

namespace OOPconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Program2 name1 = new Program2();
            Program2 name2 = new Program2();
            name2.Hello("Ado");
            name2.Hello("Kaoruko");
        }
    }
}
