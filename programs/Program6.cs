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
             if(numberOfMembers < 1){
                   Console.WriteLine(" You must have at least 1 mmber in group "); 
             }
             else if(numberOfMembers == 1)
              Console.WriteLine(name + " is a SOLO "); 
             else if(numberOfMembers == 2)
             Console.WriteLine(name+" is a Duo ");
             else 
             Console.WriteLine(name+" had "+numberOfMembers+"Members");
           }
           else
           {
             Console.WriteLine("input was not valid"); 
             Environment.Exit(0);
           }

        }
    }
}
