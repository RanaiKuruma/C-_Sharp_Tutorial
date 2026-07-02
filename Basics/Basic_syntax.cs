using System; // classes from System namespace is used 

namespace HelloWorld // Organises code and, is a container for classes and other namespaces.
{
    class Program // class is a container for data and methods, which brings functionality to your program. Every line of code that runs in C# must be inside a class. In our example, we named the class Program.
    {
        static void Main(string[] args) // Any code within the {} brackets of main method, gets executed. 
        {
            Console.WriteLine("Hello World !");
            Console.WriteLine("I am Learning C#"); 
            Console.WriteLine("It is awesome"); 
            Console.WriteLine(3 + 3); 

            // The only difference between WriteLine() and Write() is that, Write() does not insert a newline. 
            Console.Write("Hello World"); 
            Console.Write("I will print of the same line"); 

            // Comments 
            // "//" - used for comment 
            // "Multiline comment starts with: /* and ends with: */
            /* The code below will produce output at the same screen and display 
            a nice output */ 
        }
    }
}

// C# is case - sensitive 

