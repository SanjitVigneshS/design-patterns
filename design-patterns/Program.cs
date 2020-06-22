using creational_patterns;
using System;

namespace design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.GetInstance();
            //singleton.
            singleton.LogMessage("Hello");
            Console.ReadLine();
        }
    }
}
