// int time = 22; 

// if (time < 10)
// {
//     Console.WriteLine("Good Morning"); 
// }

// else if (time < 20)
// {
//     Console.WriteLine("Good day."); 
// }

// else
// {
//     Console.WriteLine("Good Evening."); 
// }

// int time = 20; 
// string result = (time < 18) ? "Good Day." : "Good evening."; 
// Console.WriteLine(result); 

// C# Switch Statements 

// Break: 
/* When C# reaches a break keyword, it breaks out of the switch block.
This will stop the execution of more code and case testing inside the block. */

// The default keyword is optional and specifies some code to run if there is no case match

// int day = 4; 
// switch (day)
// {
//     case 1: 
//         Console.WriteLine("Monday"); 
//         break; 

//     case 2: 
//         Console.WriteLine("Tuesday"); 
//         break;
    
//     case 3: 
//         Console.WriteLine("Wednesday"); 
//         break;
    
//     case 4: 
//         Console.WriteLine("Thursday"); 
//         break;
    
//     case 5: 
//         Console.WriteLine("Friday"); 
//         break;
    
//     case 6: 
//         Console.WriteLine("Saturday"); 
//         break;
    
//     case 7: 
//         Console.WriteLine("Sunday"); 
//         break;
// }

// While Loop 
// The while loop loops through a block of code as long as a specified condition is True

// int i = 0; 
// while (i < 5)
// {
//     Console.WriteLine(i); 
//     i ++; 
// }

// Do - While Loop 
// The do/while loop is a variant of the while loop. This loop will execute the code block once, before checking if the condition is true, then it will repeat the loop as long as the condition is true.

// int i = 0; 
// do
// {
//     Console.WriteLine(i); 
//     i ++; 
// }
// while(i < 5); 

// For Loop 
/*
for (statement 1; statement 2; statement 3) 
{
  // code block to be executed
}

Statement 1 is executed (one time) before the execution of the code block.

Statement 2 defines the condition for executing the code block.

Statement 3 is executed (every time) after the code block has been executed.
*/

// for (int i = 0; i < 5; i ++)
// {
//     Console.WriteLine(i); 
// }

// for (int i = 0; i <= 10; i += 2)
// {
//     Console.WriteLine(i); 
// }

// Nested Loops 
// "Inner Loop" gets executed one time for each iteration of the "Outer Loop" 

// Outer Loop 
// for (int i = 1; i <= 2; ++i)
// {
//     Console.WriteLine("Outer:" + i); // Executes 2 times

//     // Inner Loop 
//     for (int j = 1; j <= 3; j ++)
//     {
//         Console.WriteLine("Inner:" + j); // Executed 6 times 
//     }

// }

// Foreach Loop: There is also a foreach loop, which is used exclusively to loop through elements in an array (or other data sets):

/* Syntax: 
foreach (type variableName in arrayName) 
{
  // code block to be executed
}
*/

// string[] cars = {"Volve", "BMW", "Ford", "Mazda"}; 
// foreach (string i in cars)
// {
//     Console.WriteLine(i);
// }

// Break and Continue 
// The break statement is used for jumping out of the loop 

// for (int i = 0; i < 10; i ++)
// {
//   if (i == 4)
//   {
//     break;
//   }

//   Console.WriteLine(i); 
// }

// int i = 0; 
// while (i < 10)
// {
//   Console.WriteLine(i); 
//   i ++; 

//   if (i == 4)
//   {
//     break; 
//   }

// }

// The continue statement breaks one iteration (in the loop), if a specified condition occurs, and continues with the next iteration in the loop.

// for (int i = 0; i < 10; i ++)
// {
//   if (i == 4)
//   {
//     continue;
//   }

//   Console.WriteLine(i); 
// }

int i = 0; 

while (i < 10)
{
  if (i == 4)
  {
    i ++; 
    continue; 
  }

  Console.WriteLine(i); 
  i ++; 

}