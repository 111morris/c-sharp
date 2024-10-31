// for => executes while s specified boolean expression evaluates to true
// foreach => enumerates teh elets of a collection and executes its body for each element of the collection 
// do while statement conditionally executes its 

/* string? readResult;
Console.WriteLine("Enter a string: ");

do
{
 readResult = Console.ReadLine();
 Console.WriteLine(readResult);
} while (readResult == null);
 */

string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters: ");

do
{
 readResult = Console.ReadLine();
 if (readResult != null)
 {
  validEntry = true;
 }
 else
 {
  Console.WriteLine("Your input is invalid, please try again.");
 }
} while (validEntry == false);