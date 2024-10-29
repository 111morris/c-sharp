string[] names = { "Alex", "Eddie", "morris", "mulandi" };
for (int i = names.Length - 1; i >= 0; i--)
{
 Console.WriteLine(names[i]);
}
Console.WriteLine(names.Length);

for (int i = 0; i < names.Length; i++)
{
 if (names[i] == "morris")
 {
  names[i] = "Mulandi";
  Console.WriteLine($"The changed word is {names[i]}");
 }
}

foreach (var name in names) Console.WriteLine(name);