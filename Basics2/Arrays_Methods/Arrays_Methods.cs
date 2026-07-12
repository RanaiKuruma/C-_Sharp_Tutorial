// Arrays 
// string[] cars = {"Volvo", "BMW", "Ford", "Mazda"}; 

// int[] myNum = {10, 20, 30, 40}; 
// Console.WriteLine(cars[0]); 
// cars[0] = "Ferrari"; 
// Console.WriteLine(cars[0]); 

// Console.WriteLine(cars.Length); 

// Alternate methods to create an array
// string[] cars = new string[4] {"Volvo", "BMW", "Ford", "Mazda"}; 
// string[] cars = new string[] {"Volvo", "BMW", "Ford", "Mazda"}; 

// Loop through an array 
// string[] cars = {"Volvo", "BMW", "Ford", "Mazda"}; 

// for (int i = 0; i < cars.Length; i ++)
// {
//     Console.WriteLine(cars[i]); 
// }

// foreach loop: Used only for traversing through the elements of the array 
// foreach(string i in cars)
// {
//     Console.WriteLine(i); 
// }

// Sorting an Arrays 
// Array.Sort(cars); 
// for (int i = 0; i < cars.Length; i ++)
// {
//     Console.WriteLine(cars[i]); 
// }

// int[] myNumbers = {5, 1, 8, 9}; 
// Array.Sort(myNumbers); 
// for (int i = 0; i < myNumbers.Length; i ++)
// {
//     Console.WriteLine(myNumbers[i]); 
// }

// Multi - Dimensional Arrays 
// int[,] numbers = { {1, 4, 2}, {3, 6, 8} }; 

// Accessing elements of an multidimensioanl array 
// Console.WriteLine(numbers[0, 2]); 
// numbers[0, 0] = 5; 
// Console.WriteLine(numbers[0, 0]); 

// Looping through an multidimensional array 
// Use GetLength() - specify how many times a loop should run 

// for (int i = 0; i < numbers.GetLength(0); i ++)
// {
//     for (int j = 0; j < numbers.GetLength(1); j ++)
//     {
//         Console.WriteLine(numbers[i, j]); 
//     }
// }


// Methods 
/*A method is a block of code which only runs when it is called. You can pass data, known as parameters, into a method. Methods are used to perform certain actions, and they are also known as functions.*/

// create a method syntax: 
// class Program
// {
//     static void MyMethod()
//     {
//         // Code to Be executed; 
//     }
// }

/*
MyMethod() is the name of the method. 

Static means that the method belongs to the Program class and not an object of the Program class. 

void means that this method does not have a return value. 
*/

class Program
{
    // static void MyMethod()
    // {
    //     Console.WriteLine("I just got executed"); 
    // }

    // static void Main(string[] args)
    // {
    //     MyMethod(); 
    // }

    // Parameters 
    // static void MyMethod(string fname)
    // {
    //     Console.WriteLine(fname + " Refsnes"); 
    // }

    // static void Main(string[] args)
    // {
    //     MyMethod("Liam"); 
    //     MyMethod("Jenny"); 
    //     MyMethod("Anja"); 
    // }

    // static void MyMethod(string fname, int age)
    // {
    //     Console.WriteLine(fname + " is " + age); 
    // }

    // static void Main(string[] args)
    // {
    //     MyMethod("Liam", 5); 
    //     MyMethod("Jenny", 8); 
    //     MyMethod("Anja", 31); 
    // }

    // static void MyMethod(string country = "Norway")
    // {
    //     Console.WriteLine(country); 
    // }

    // static void Main(string[] args)
    // {
    //     MyMethod("Sweden"); 
    //     MyMethod("India"); 
    //     MyMethod("USA"); 
    // }

    // static int MyMethod(int x, int y)
    // {
    //     return x + y; 
    // }

    // static void Main(string[] args)
    // {
    //     Console.WriteLine(MyMethod(5, 3)); 
    // }

    // Named Arguments 
    /*It is also possible to send arguments with the key: value syntax. That way, the order of the arguments does not matter:*/
    // static void MyMethod(string child1, string child2, string child3)
    // {
    //     Console.WriteLine("The youngest child is : " + child3); 
    // }

    // static void Main(string[] args)
    // {
    //     MyMethod(child3: "John", child1: "Liam", child2: "Liam"); 
    // }

    // Method Overloading 
    static int PlusMethodInt(int x, int y)
    {
        return x + y; 
    }

    static double PlusMethodDouble(double x, double y)
    {
        return x + y; 
    }

    static void Main(string[] args)
    {
        int myNum1 = PlusMethodInt(8, 5); 
        double myNum2 = PlusMethodDouble(4.3, 6.26); 
        
        Console.WriteLine("Int:" + myNum1); 
        Console.WriteLine("Double:" + myNum2); 
    }
}
