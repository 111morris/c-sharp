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