using System;

namespace program4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the name of your band");
            string name=Console.ReadLine();
            Console.WriteLine("How many people are in your band?");
             int numberOfMembers = 0;
           if(int.TryParse(Console.ReadLine(), out numberOfMembers))
           {
             Console.WriteLine(name + " band has " + numberOfMembers); 
              Environment.Exit(0);
           }
           else
           {
             Console.WriteLine("input was not valid"); 
             Environment.Exit(0);
           }

        }
    }
}
