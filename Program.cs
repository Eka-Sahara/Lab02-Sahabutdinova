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

System.Console.WriteLine();
System.Console.WriteLine("char");

char firstLetter = 'A';
char separator = '-';
int charAsNumber = firstLetter;     //char можно неявно превратить в int - это код символа в таблице Unicode
System.Console.WriteLine($"Символ: {firstLetter}, разделитель: {separator}");
System.Console.WriteLine($"Код символф: '{firstLetter}', в Unicode: {charAsNumber}");
System.Console.WriteLine($"Табуляция:\tпосле таба");
System.Console.WriteLine($"Перенос:\nпосле переноса");

System.Console.WriteLine();
System.Console.WriteLine("decimal против double");

double priceDouble = 0.1 + 0.2;
decimal priceDecimal = 0.1m + 0.2m;

System.Console.WriteLine($"double: 0.1 + 0.2 = {priceDouble}");
System.Console.WriteLine($"decimal: 0.1 + 0.2 = {priceDecimal}");
