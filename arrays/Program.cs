using System.Globalization;
using System.Text.RegularExpressions;

string[] make = new string[3];

make[0] = "1234.index-1";
make[1] = "13512.index-2";
make[2] = "1613.index-3";
Console.WriteLine("hey look at this\n");
for (int i = 0; i < make.Length; i++)
{
 Console.WriteLine(make[i]);
}

Console.WriteLine("the second number is \n");
foreach (string number in make)
{
 Console.WriteLine(number);
}

Console.WriteLine("the third line \n");

string[] names = { "morris", "mulandi", "mwani", "how is", "you ", "how was your night" };

foreach (string name in names)
{
 Console.WriteLine(name);
}

Console.WriteLine("hello \n");

int[] inventoryL = { 200, 450, 700, 175, 250 };
int totalInvetory = 0;
int bin = 0;
foreach (int inventory in inventoryL)
{
 totalInvetory += inventory;
 bin++;
 Console.WriteLine($"Bin {bin} = {inventory} items (Running total: {totalInvetory})");
}

Console.WriteLine($"The total inventory is: {totalInvetory}");

// nested iteration and selection stetements 
string[] ids = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string id in ids)
{
 if (id.StartsWith("B"))
 {
  Console.WriteLine($"The name starts with 'B': {id}");
 }
}