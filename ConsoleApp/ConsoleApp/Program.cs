// Before .net6, static void main was required

// Console.WriteLine("Hello, World!");
// Console.ReadLine();

/*
 VARIABLES
 */

int a = 99;
string b = "abc";
byte c = 255;
char d = 'a';
double e = 14.43;
float f = 14.43f;
decimal g = 14.43m; // 28 digits of precision


// type casting
// string to int
//string value = "12345";

//int result = 0;

//result = int.Parse(value);

//Console.WriteLine(result);
//Console.WriteLine(result.GetType());


// safe conversion
string value = "12345";

int result = 0;

if (int.TryParse(value, out result))
{
    Console.WriteLine("Success: ", result);
}
else
{
    Console.WriteLine("Failure");
}

Console.WriteLine(result);
Console.WriteLine(result.GetType());
