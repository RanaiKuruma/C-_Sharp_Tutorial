// Implicit Casting
// Implicit casting is done automatically when passing a smaller size type to a larger size type
int myint = 9; 
double mydouble = myint; 

Console.WriteLine(myint); 
Console.WriteLine(mydouble); 

// Explicit Casting
// Explicit casting must be done manually by placing the type in parentheses in front of the value:
double mydoublenum = 9.78; 
int myinteger = (int) mydoublenum; 

Console.WriteLine(mydoublenum); 
Console.WriteLine(myinteger); 

// Type Conversion methods 
int myint2 = 10; 
double mydouble2 = 5.25; 
bool myBool = true; 

Console.WriteLine(Convert.ToString(myint2)); 
Console.WriteLine(Convert.ToDouble(myint2)); 

Console.WriteLine(Convert.ToInt32(mydouble2)); 
Console.WriteLine(Convert.ToString(myBool)); 
