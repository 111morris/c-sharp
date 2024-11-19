int numericValue = 0, i = 10;
bool validNumber = false;
string? readResult;

Console.WriteLine("Please enter a value between 5 and 10");
while (i <= 0)
{
 readResult = Console.ReadLine();
 validNumber = int.TryParse(readResult, out numericValue);
 i--;
}