using System;

namespace program4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the name of your band");
            string name=Console.ReadLine();
            Console.WriteLine(" How many people are in your band");
            int num=int.Parse(Console.ReadLine());
            Console.WriteLine(name + "has" + num);

        }
    }
}
