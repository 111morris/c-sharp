// string pangram = "morris is listening to music while learning";
// string pangram = "The quick brown fox jumps over the lazy dog";
// string pangram = "The quick brown fox jumps over the lazy dog";

// split the string
// convert to a character array
// reverse the array 
// Split(), ToCharArray(), Array.Reverse(), String.Join()
/******************************************************************************/
/* string pangramRefined = "";
string[] pangramArray = pangram.Split(' ');
foreach(string p in pangramArray){
 char[] pArray = p.ToCharArray();
 Array.Reverse(pArray);
 // Console.WriteLine(pArray);
 // Console.WriteLine(pArray.Length);
 for (int i = 0; i < pArray.Length; i++)
 {
  pangramRefined += pArray[i];
 }
 pangramRefined += ' ';
}

Console.WriteLine(pangramRefined);
 */

/*********************************************************************/
/* string pangram2 = "The quick brown fox jumps over the lazy dog";

// Step 1
string[] message = pangram2.Split(' ');

//Step 2
string[] newMessage = new string[message.Length];

// Step 3
for (int i = 0; i < message.Length; i++)
{
 char[] letters = message[i].ToCharArray();
 Array.Reverse(letters);
 newMessage[i] = new string(letters);
}

//Step 4
string result = String.Join(" ", newMessage);
Console.WriteLine(result); */


string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// split
// sort the list
// check if it is less

string[] orderStreamArray = orderStream.Split(',');

Array.Sort(orderStreamArray);

foreach(var orderstrems in orderStreamArray){
 if (orderstrems.Length == 4) Console.WriteLine(orderstrems); else Console.WriteLine($"{orderStream} - Error");
}