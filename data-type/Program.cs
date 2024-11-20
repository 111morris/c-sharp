// what is a data type?
/* 
-a data type is a way a programming language defines hwo much much memory to save for a value. there are many data types in the c# language to be used for many different applications and sizes of data
 */

Console.WriteLine("Signed integral types:");

Console.WriteLine($"byte : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short: {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int : {int.MinValue} to {int.MinValue}");
Console.WriteLine($"long : {long.MinValue} to {long.MaxValue}");

Console.WriteLine($"\n\nUnsigned integral types: \nbyte : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"long : {ulong.MinValue} to {ulong.MaxValue}");
Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

// <==== reference types and value types ====>
// reference type variable stores its values directly in an area of storage called the stack
// reference type variable stores its value in a separate memory region called the heap 

int[] data = new int[3];
Console.WriteLine("start");
Console.WriteLine(data);

int val_A = 2;
int val_B = val_A;

val_B = 5;
Console.WriteLine("--Value Types--");
Console.WriteLine($"val_A: {val_A}");
Console.WriteLine($"val_B: {val_B}");

// <--reference type (array)
int[] ref_A = new int[1];
ref_A[0] = 2;
int[] ref_B = ref_A;

ref_B[0] = 5;

Console.WriteLine("--reference types--");
Console.WriteLine($"ref_A[0]: {ref_A[0]}");
Console.WriteLine($"ref_B[0]: {ref_B[0]}");