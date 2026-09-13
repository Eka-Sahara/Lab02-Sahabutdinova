System.Console.WriteLine("Границы целочисленных типов");
System.Console.WriteLine($"byte: {byte.MinValue} .. {byte.MaxValue}");
System.Console.WriteLine($"short: {short.MinValue} .. {short.MaxValue}");
System.Console.WriteLine($"int: {int.MinValue} .. {int.MaxValue}");
System.Console.WriteLine($"long: {long.MinValue} .. {long.MaxValue}");

System.Console.WriteLine();
System.Console.WriteLine("Границы дробных типов");
System.Console.WriteLine($"float: {float.MinValue} .. {float.MaxValue}");
System.Console.WriteLine($"double: {double.MinValue} .. {double.MaxValue}");
System.Console.WriteLine($"decimal: {decimal.MinValue} .. {decimal.MaxValue}");

System.Console.WriteLine();
System.Console.WriteLine("Переполнение byte");

byte maxByte = 255;
byte overflowed = (byte)(maxByte + 1);
System.Console.WriteLine($"255 + 1 для byte = {overflowed}");