// System.Console.WriteLine("Границы целочисленных типов");
// System.Console.WriteLine($"byte: {byte.MinValue} .. {byte.MaxValue}");
// System.Console.WriteLine($"short: {short.MinValue} .. {short.MaxValue}");
// System.Console.WriteLine($"int: {int.MinValue} .. {int.MaxValue}");
// System.Console.WriteLine($"long: {long.MinValue} .. {long.MaxValue}");

// System.Console.WriteLine();
// System.Console.WriteLine("Границы дробных типов");
// System.Console.WriteLine($"float: {float.MinValue} .. {float.MaxValue}");
// System.Console.WriteLine($"double: {double.MinValue} .. {double.MaxValue}");
// System.Console.WriteLine($"decimal: {decimal.MinValue} .. {decimal.MaxValue}");

// System.Console.WriteLine();
// System.Console.WriteLine("Переполнение byte");

// byte maxByte = 255;
// byte overflowed = (byte)(maxByte + 1);
// System.Console.WriteLine($"255 + 1 для byte = {overflowed}");

// System.Console.WriteLine();
// System.Console.WriteLine("char");

// char firstLetter = 'A';
// char separator = '-';
// int charAsNumber = firstLetter;     //char можно неявно превратить в int - это код символа в таблице Unicode
// System.Console.WriteLine($"Символ: {firstLetter}, разделитель: {separator}");
// System.Console.WriteLine($"Код символф: '{firstLetter}', в Unicode: {charAsNumber}");
// System.Console.WriteLine($"Табуляция:\tпосле таба");
// System.Console.WriteLine($"Перенос:\nпосле переноса");

// System.Console.WriteLine();
// System.Console.WriteLine("decimal против double");

// double priceDouble = 0.1 + 0.2;
// decimal priceDecimal = 0.1m + 0.2m;

// System.Console.WriteLine($"double: 0.1 + 0.2 = {priceDouble}");
// System.Console.WriteLine($"decimal: 0.1 + 0.2 = {priceDecimal}");

// System.Console.WriteLine();
// System.Console.WriteLine("var");

// var studentAge = 20;    // компилятор вывел int
// var gpa = 4.75; // компиляор вывел double
// var fullName = "Смирнова А.С."; // компилятор вывел string

// System.Console.WriteLine($"{fullName}, возраст {studentAge}, средний балл {gpa}");

// System.Console.WriteLine();
// System.Console.WriteLine("Ввод текста");

// System.Console.Write("Введите ваше имя: ");
// string enteredName = Console.ReadLine();

// System.Console.Write("Введите название вашей группы: ");
// string enteredGroup = Console.ReadLine();

// System.Console.WriteLine($"Здравствуйте, {enteredName} из группы {enteredGroup}!");

// System.Console.WriteLine();
// System.Console.WriteLine("Ввод чисел: Convert и Parse");

// System.Console.Write("Введите ваш год рождения: ");
// string birthYearInput = Console.ReadLine();

// int birthYearConvert = Convert.ToInt32(birthYearInput);
// int birthYearParse = int.Parse(birthYearInput);

// System.Console.WriteLine($"Convert.ToInt32: {birthYearConvert}");
// System.Console.WriteLine($"int.Parse:       {birthYearParse}");
// System.Console.WriteLine($"В 2030 году вам будет: {2030 - birthYearConvert} лет");

// System.Console.WriteLine();
// System.Console.WriteLine("Ввод чисел: TryParse");

// System.Console.Write("Введите количество прочитанных книг за семестр: ");
// string booksInput = Console.ReadLine();

// bool wasSuccessful = int.TryParse(booksInput, out int booksCount);

// System.Console.WriteLine($"Удалось преобразовать: {wasSuccessful}");
// System.Console.WriteLine($"Значение переменной booksCount: {booksCount}");



// System.Console.Write("Введите имя и фамилию: ");
// string enteredName = Console.ReadLine();

// System.Console.Write("Введите группу: ");
// string enteredGroup = Console.ReadLine();

// System.Console.Write("Введите год рождения: ");
// string birthYearInput = Console.ReadLine();

// System.Console.Write("Введите средний балл: ");
// string enteredGpa = Console.ReadLine();

// System.Console.Write("Введите любимую букву: ");
// string enteredFavoriteLetter = Console.ReadLine();

// int birthYearConvert = Convert.ToInt32(birthYearInput);

// double GpaConvert = Convert.ToDouble(enteredGpa);

// System.Console.WriteLine("  Анкета");
// System.Console.WriteLine($"{enteredName}, группа {enteredGroup}");
// System.Console.WriteLine($"Год рождения: {birthYearConvert} (в 2030 будет {2030 - birthYearConvert} год)");
// System.Console.WriteLine($"Средний балл: {GpaConvert}");
// System.Console.WriteLine($"Балл >= 4.0: True ");
// System.Console.WriteLine($"Любимая буква: {enteredFavoriteLetter}");

// System.Console.WriteLine();

// System.Console.Write("Введите ваш рост(м): ");
// string enteredHeight = Console.ReadLine();

// System.Console.Write("Введите ваш вес(кг): ");
// string enteredWeight = Console.ReadLine();

// double heightConvert = Convert.ToDouble(enteredHeight);
// double weightConvert = Convert.ToDouble(enteredWeight);

// double bmi = weightConvert / (heightConvert * heightConvert);

// System.Console.WriteLine($"ИМТ: {bmi:F2}");


System.Console.WriteLine();
System.Console.WriteLine("Разбор ФИО через char");
System.Console.Write("Введите фамилию: ");
string enteredSurname = Console.ReadLine();
System.Console.Write("Введите имя: ");
string enteredName = Console.ReadLine();
char name = enteredName[0];

System.Console.WriteLine($"{enteredSurname} {name}.");