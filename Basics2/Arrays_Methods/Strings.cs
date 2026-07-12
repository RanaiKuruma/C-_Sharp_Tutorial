// string greeting = "Hello"; 
// Console.WriteLine(greeting); 

// string greeting2 = "Nice to meet you!"; 
// Console.WriteLine(greeting2); 

// string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; 
// Console.WriteLine(txt.Length); 

// string txt2 = "Hello World"; 
// Console.WriteLine(txt2.ToUpper()); 
// Console.WriteLine(txt2.ToLower()); 

// Concatenation 
// string firstName = "John "; 
// string lastName = "Doe"; 
// // string name = firstName + lastName; 
// // Console.WriteLine(name); 

// string name = string.Concat(firstName, lastName); 
// Console.WriteLine(name); 

// Interpolation 
/* which substitutes values of variables into placeholders in a string. Note that you do not have to worry about spaces, like with concatenation */
// string firstName = "John "; 
// string lastName = "Doe"; 
// string name = $"My full name is : {firstName} {lastName}"; 
// Console.WriteLine(name); 

// Access Strings 
// string myString = "Hello"; 
// Console.WriteLine(myString[0]); 

/* Another useful method is Substring(), which extracts the characters from a string, starting from the specified character position/index, and returns a new string. This method is often used together with IndexOf() to get the specific character position */

// Full name
// string name = "John Doe"; 

// Location of the letter D
// int charPos = name.IndexOf("D"); 

// Get last name
// string lastName = name.Substring(charPos); 

// Print the result 
// Console.WriteLine(lastName); 

// Special Characters: \' (gives a single quote), \'' (gives a double quote), \\ (gives a Backlash)
// string txt = "We are the so called \"Vikings\" of the north.";
// string txt = "It\'s alright"; 
// string txt = "The character \\ is called backslash."; 
// string txt = "Hello\nWorld!";
// string txt = "Hel\blo World!";
// Console.WriteLine(txt); 

// Booleans

// bool isCSharpFun = true; 
// bool isFishTasty = false; 
// Console.WriteLine(isCSharpFun); 
// Console.WriteLine(isFishTasty); 

// Console.WriteLine(10 > 9); 

// int x = 10; 
// Console.WriteLine(x == 10); 

// Console.WriteLine( 10 == 25 ); 

// int myAge = 25; 
// int votingAge = 18; 

// // Console.WriteLine(myAge >= votingAge); 

// if (myAge >= votingAge)
// {
//     Console.WriteLine("Yes"); 
// }

// else
// {
//     Console.WriteLine("No"); 
// }

int time = 22; 

if (time < 10)
{
    Console.WriteLine("Good Morning"); 
}

else if (time < 20)
{
    Console.WriteLine("Good day."); 
}

else
{
    Console.WriteLine("Good Evening."); 
}

