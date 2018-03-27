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



