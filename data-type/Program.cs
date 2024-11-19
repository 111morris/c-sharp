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