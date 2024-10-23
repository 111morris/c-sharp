for (int i = 0; i < 10; i++)
{
 Console.WriteLine(i);
}

for (int i = 10; i >= 0; i--)
{
 Console.WriteLine(i);
}

for (int i = 0; i < 10; i += 3)
{
 Console.WriteLine(i);
}
Console.WriteLine("\n");
for (int i = 0; i < 10; i++)
{
 Console.WriteLine(i);
 if (i == 7) break;
}

// loop through each element of an array

string[] names = { "Alex", "Maya", "Eddie", "David", "Michael" };
Console.WriteLine($"this is the number of names {names.Length} characters");
for (int i = names.Length - 1; i >= 0; i--)
{
 Console.WriteLine(names[i]);
};
for(int i = 0; i<names.Length; i++) {
 Console.WriteLine(names[i]);
};

string[] name = { "Moureen", "Alex", "Maya", "Eddie", "David", "Michael" };
for(int i = 0; i <name.Length; i++) {
 if (name[i] == "Maya") name[i] = "Maya Mulandi";
}
foreach(var n in name ) Console.WriteLine(n);
