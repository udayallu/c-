# c#
C# is a multi-paradigm programming language encompassing strong typing, imperative, declarative, functional, generic, object-oriented, and component-oriented programming disciplines.

### Hello world Program
```
using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UDAY ALLU");
        }
    }
}

```
![alt text](https://github.com/udayallu/csharp/blob/master/data/prog1.png)
### Accepting the input from the user and printing it 
```
using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Message");
            Console.WriteLine("you said "+ Console.ReadLine());
        }
    }
}
```
![alt text](https://github.com/udayallu/csharp/blob/master/data/prog2.png)
###  String Concatenation
```
using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Message");
            Console.WriteLine("you said " + "uday");
        }
    }
}
```
![alt text](https://github.com/udayallu/csharp/blob/master/data/prog3.png)
## Variables
### Storing Information in Variables
```
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

```
![alt text](https://github.com/udayallu/csharp/blob/master/data/prog4.png)


## Using Conditions
```
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

```
![alt text](https://github.com/udayallu/csharp/blob/master/data/prog5.png)

## Expressions
### Declaring Our Band Type Using Conditions
```
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
             Console.WriteLine(name+" had "+numberOfMembers+" Members");
           }
           else
           {
             Console.WriteLine("input was not valid"); 
             Environment.Exit(0);
           }

        }
    }
}

```
