
// record the date and time, patient age, height, weight, pulse, and blood pressue
// The application also provides text fields for other information, such as the reason for the visit, current prescriptions, and other items
// you will collect all the inputs as strings

using System.Globalization;
using System.Numerics;

int num_1 = 10;
string num_2 = "20";

string sum = num_1 + num_2;
Console.WriteLine(sum);
/* 
To perform data conversion, you can use one of several techniques:

Use a helper method on the data type
Use a helper method on the variable
Use the Convert class' methods */

int myInt = 3;
Console.WriteLine($"int: {myInt}");
decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");
decimal myDecimal2 = 3.42m;
Console.WriteLine($"decimal: {myDecimal2}");
int myInt2 = (int)myDecimal2;
Console.WriteLine(myInt2);

// determine if your conversion is a widening conversion or a narrowing conversion

decimal myDecimal3 = 1.23456789m;
float myFloat = (float)myDecimal3;

Console.WriteLine($"Decimal: {myDecimal3}");
Console.WriteLine($"Float: {myFloat}");

// us ToString() to convert a number to a string 


int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);

// Convert a string to an int using the perse() helper method 

/* we can cast by 
 (<data_type>)varible,
 perse (<data_type>).perse(), 
 <variable>.ToString() 
 using the class => Convert.ToInt32(<vairable>) */

// examine the TryParse() method

string value = "12309t";
int result = 0;

if (int.TryParse(value, out result))
{
 Console.WriteLine($"The output is: {result}");

}
else
{
 Console.WriteLine("We're unable to report the measurement. Please try again.");
};
if (result > 0)
 Console.WriteLine($"Measurement (w/ offset): {50 + result}");

/* 
The TryParse() method is a valuable tool.Here are few quick ideas to remember.

Use TryParse() when converting a string into a numeric data type.
TryParse() returns true if the conversion is successful, false if it's unsuccessful.
Out parameters provide a secondary means of a method returning a value. In this case, the out parameter returns the converted value.
Use the keyword out when passing in an argument to a method that has defined an out parameter. */

string myInput = "2.71828";
decimal myInputDecimal = 0;
if (true)
{
 Console.WriteLine("The Value is: ");
 Console.Write(decimal.TryParse(myInput, out myInputDecimal));
}

// CultureInfo.CurrentCulture = new CultureInfo("en-US");


// <<<<<<<======= challange 1 =====>>>>> 
string[] values = { "12.3", "45", "ABC", "11", "DEF" };
decimal total = 0m;
string msg = "";
foreach (var v in values)
{
 decimal number;
 if (decimal.TryParse(v, out number))
 {
  total += number;
 }
 else
 {
  msg += v;
 }
}


Console.WriteLine($"\nMessage: {message}");
Console.WriteLine($"Total: {total}");


string testing = "4.1234567890";
decimal make = Convert.ToDecimal(testing);
decimal make2;
decimal.TryParse(testing, out make2);

Console.WriteLine($"make: {make}");
Console.WriteLine($"make2: {make2}");