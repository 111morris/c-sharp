using System.Data;

Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue.ToUpper()=="a");


string pangram = "The quick brown fox jumps over the lazy dog.";

Console.WriteLine(pangram.Contains("fox"));

// These two lines of code will create the same output

Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));

int purchase = 13491;
bool discount = false; 
if(purchase>1000) {
 discount = true;
}else{
 discount = false;
}
if(discount) {
 Console.WriteLine("You have been rewarded 100% discount");
} else{
 Console.WriteLine("You havn't been discounted try again later");
}

Console.WriteLine("\n");

string discount2 = purchase > 1000 ? "discount is 100%" : "discount is less than 100%";

Console.WriteLine(discount2);
Console.WriteLine("\n");
Console.WriteLine($"Discount: {(purchase>1000? "congratulation 100%": "sorry not today!")}");

// Code challenge to display the result of a coin flip
Random coin = new Random();
int flip = coin.Next(0, 2);

Console.WriteLine((flip == 0) ? "head" : "tails");

Console.WriteLine((coin.Next(0, 2)) == 0 ? "heads" : "Tails");

Console.WriteLine("\n");
string permission = "Admin|Manager";
int level = 55;