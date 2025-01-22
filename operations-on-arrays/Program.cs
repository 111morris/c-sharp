using System.Net.Quic;
using System.Security.AccessControl;
// common operation across those projects are adding, sorting, deleting, combining, calculating, validating data and formatting output
// arrays operations => adding, deleting, sorting, combining, calculating, validating data, and formating ouput

/* helper methods to sort or reverse the data
    clear and resize elements of an arrays
    spliting arrays 
    join arrays */

// sort() and reverse() 
string[] pallets = ["B14", "A11", "B12", "A13"];

Console.WriteLine("Sorted ...");
Array.Sort(pallets);

foreach (var pallet in pallets)
{
 Console.WriteLine($"-- {pallet}");
}
Console.WriteLine("Done! sorting");

Console.WriteLine("\nReversed ...");
Array.Reverse(pallets);

foreach (var pallet in pallets)
{
 Console.WriteLine($"-- {pallet}");
}

int[] testing = { 1, 2, 9, 4, 8, 6, 7, 5, 3 };

Array.Sort(testing);
foreach (var test in testing)
{
 Console.WriteLine($"-- {test}");
}

// clear() and resize()

string[] pallets2 = ["B14", "A11", "B12", "A13"];

Array.Clear(pallets2, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets2.Length}");

foreach (var pallet in pallets2)
{
 Console.WriteLine($"-- {pallet}");
}

// it clears the value stored in the elements of the pallets arrays starting at index 0 and clearing 2 elements 
Console.WriteLine($"Before: {pallets[0]}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"After: {pallets[0]}");

foreach (var pallet in pallets2)
{
 Console.WriteLine($"-> {pallet}");
}

// call a string helper method on a cleared element
/* Console.WriteLine($"Before: {pallets[0].ToLower()}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"After: {pallets[0].ToLower()}");


foreach (var pallet in pallets)
{
 Console.WriteLine($"<-> {pallets}");

} */

// QuicReceiveWindowSizes the array to add more elements

Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets) {
 Console.WriteLine($"-- {pallet}");
}
Array.Resize(ref pallets, 3);
Console.WriteLine($"\nResizing 3 ... count: {pallets.Length}");

foreach(var pallet in pallets){
 Console.WriteLine($"<=> {pallet}");
}


// StringSplitOptions() and join()

Console.WriteLine("Split and Join");
// convert string to an array of characters
// join with ","
// split 

string value = "abc123";
char[] valueArray = value.ToCharArray();

Console.WriteLine(valueArray);

Array.Reverse(valueArray);

// string result = new string(valueArray);
string result = string.Join(", ", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
 Console.WriteLine(item);
}