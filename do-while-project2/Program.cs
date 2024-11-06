// a code that validates a string input 

Console.WriteLine("Enter your role name (Administrator, Manager, or user)");

do
{
 string? input = Console.ReadLine();

 if (input.Trim().ToLower() == "admnistrator" || input.Trim().ToLower() == "manager" || input.Trim().ToLower() == "user")
 {
  Console.WriteLine($"Your input value ({input}) has been accepted");
  break;
 }
 else
 {
  Console.WriteLine($"The role that you entered, \"{input.ToLower()}\" is not valid. Enter your role name (Administrator, Manager, User)");
 }
} while (true);

