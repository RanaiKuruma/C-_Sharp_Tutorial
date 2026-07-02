// String data type 
string name = "John"; 
Console.WriteLine(name); 

// Int variable data type 
int myNum = 7; 
Console.WriteLine(myNum); 

int myNum2; 
myNum2 = 8; 
Console.WriteLine(myNum2); 

// Note that if you assign a new value to an existing variable, it will overwrite the previous value
int myNum3 = 7; 
myNum3 = 99; 
Console.WriteLine(myNum3); 

// Other types of data 
double myDoubleNum = 5.99; 
Console.WriteLine(myDoubleNum); 

// Char take input only in single quotes
char myLetter = 'R'; 
Console.WriteLine(myLetter);

bool myBool = true; 
Console.WriteLine(myBool);

string myText = "Hello"; 
Console.WriteLine(myText);

// Constants 
// The constant keyword declares the variable as "constant", which means unchangeable and read only 
const int randomNum = 15; 
// randomNum = 20;
Console.WriteLine(randomNum); 

/*The WriteLine() method is often used to display variable values to the console window.
To combine both text and a variable, use the + character: */
string name2 = "John"; 
Console.WriteLine("Hello" + name2); 

string firstName = "John"; 
string lastName = "Doe"; 
string fullName = firstName + lastName; 
Console.WriteLine(fullName); 

int x = 7; 
int y = 10; 
int sum = x + y; 
Console.WriteLine(sum); 

// Declare multiple variables 
int a = 5, b = 6, c = 7; 
Console.WriteLine(a + b + c); 

int d, e, f; 
d = e = f = 50; 
Console.WriteLine(d + e + f); 

// Identifiers 
/* All C# variables must be identified with unique names.

These unique names are called identifiers.

Identifiers can be short names (like x and y) or more descriptive names (age, sum, totalVolume).

Note: It is recommended to use descriptive names in order to create understandable and maintainable code: */

// int minutesPerHour = 60; 
// int m = 60; 

/* The general rules for naming variables are:
Names can contain letters, digits and the underscore character (_)
Names must begin with a letter or underscore
Names should start with a lowercase letter, and cannot contain whitespace
Names are case-sensitive ("myVar" and "myvar" are different variables)
Reserved words (like C# keywords, such as int or double) cannot be used as names */

// DataTypes 

// Long 
long mynumber = 150000000000000000L; 
Console.WriteLine(mynumber); 

// Float, sufficient for storing 6 to 7 decimal digits 
float mynumber2 = 5.75F;
Console.WriteLine(mynumber2);

// Double, sufficient for storing 15 decimal digits 
double mynumber3 = 19.99D; 
Console.WriteLine(mynumber3); 

// Scientific Number 
// "e" indicates the power of 10
float f1 = 35e3F; 
double d1 = 12E4D; 
Console.WriteLine(f1); 
Console.WriteLine(d1); 

// Boolean Type 
bool isCSharpFun = true; 
bool isFishTasty = false; 
Console.WriteLine(isCSharpFun); 
Console.WriteLine(isFishTasty); 