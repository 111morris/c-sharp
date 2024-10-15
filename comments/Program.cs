using System.Runtime.InteropServices;

Random random = new Random();

string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
 // get a random number that equates to ASCII letters A through E
 int prefixValue = random.Next(65, 81);
 string prefix = Convert.ToChar(prefixValue).ToString();
 string suffix = random.Next(1, 1000).ToString("000");
 orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
 Console.WriteLine(orderID);
}

Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
 if ((roll1 == roll2) && (roll2 == roll3))
 {
  Console.WriteLine("You rolled triples!  +6 bonus to total!");
  total += 6;
 }
 else
 {
  Console.WriteLine("You rolled doubles!  +2 bonus to total!");
  total += 2;
 }
}