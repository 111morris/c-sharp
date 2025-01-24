// what is composite formatting
/* 
string first = "hello";
string second = "world";
string res = string.Join(" ", first, second);
string result = string.Format("{1} {0}!", first, second);
Console.WriteLine(res);
Console.WriteLine(result);

Console.WriteLine("");
Console.WriteLine("{1} {0}@", first, second);


// what is string interpolation 
Console.WriteLine($"{first} {second} she");
// formatting currency
decimal price1 = 123.25m;
int discount = 50;

Console.WriteLine($"Price: {price1:C} (Save {discount:C})");
// number formatting
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N3} units");

// percentages formatting 
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P3}");


decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price", (price - salePrice), price);

Console.WriteLine(yourDiscount); */

// C,N,P


/* padding and alignment */


/*
method{
 // Methods that add blank spaces for formatting purposes 
 PadLeft(),
 PadRight(),
 // Methods that compare two strings or facilitate comparison
 Trim(),
 TrimEnd(),
 TrimStart(),
 GetHashcode(),
 Length(),
 // Methods that help you determine what's inside of a string, or even retrieve just a part of the string 
 Contains(),
 StrartWith()
 EndsWith(),
 Substring(),
 // Methods that change the content of the string by replacing, inserting, or removing parts
 Replace(),
 Insert(),
 Remove(),
 // Methods that turn a string into an array of strings or characters
 Split(),
 ToCharArrays()
}
*/
string name = "morris";
Console.WriteLine($"hello {name.PadLeft(8)}");
Console.WriteLine($"hello {name.PadLeft(8, '-')}");