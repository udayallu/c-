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

