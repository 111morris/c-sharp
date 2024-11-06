// A code that validates integer input 
using System.Linq.Expressions;

Console.WriteLine("Please enter an integer value between 5 and 10");

int number;
bool isValid;

do
{
 string? input = Console.ReadLine();
 isValid = int.TryParse(input, out number);
 if (isValid && number >= 5 && number <= 10)
 {
  Console.WriteLine($"Succss, you entered {number}. Your input has been accepted.");
  break;
 }
 else if (!isValid)
 {
  Console.WriteLine("Invalid input. Please enter a valid number between 5 and 10");
 }
 else
 {
  Console.WriteLine($"You entered {number}. Please enter a nuber between 5 and 10");
 }
} while (true);