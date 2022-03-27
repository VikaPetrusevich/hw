//Изучить методы Parse и TryParse типа int, char, DateTime. 

//Метод Parse() в качестве параметра принимает строку и возвращает объект текущего типа.

var number = int.Parse("100");
Console.WriteLine(number);

//var incorrectNumber = int.Parse("Hello"); System.FormatException: 'Input string was not in a correct format.'
//Console.WriteLine(incorrectNumber);

var symbol = char.Parse("H");
Console.WriteLine(symbol);

//var incorrectSymbol = char.Parse("Hello"); System.FormatException: 'String must be exactly one character.' 
//Console.WriteLine(incorrectSymbol);

var date = DateTime.Parse("25.03.2022");
Console.WriteLine(date);

//var incorrectdate = DateTime.Parse("26032022"); System.FormatException:
//'String '26032022' was not recognized as a valid DateTime.'
//Console.WriteLine(incorrectdate);

//Метод TryParse() пытается преобразовать строку к типу и, если преобразование прошло успешно, то возвращает true.
//Иначе возвращается false

int number2;
var isParse = int.TryParse("150", out number2);
Console.WriteLine(isParse); //True
Console.WriteLine(number2);

int number3;
var isParse2 = int.TryParse("Guys", out number3);
Console.WriteLine(isParse2); //False
Console.WriteLine(number3);

char symbol2;
var isParse3 = char.TryParse("W", out symbol2);
Console.WriteLine(isParse3); //True
Console.WriteLine(symbol2);

char symbol3;
var isParse4 = char.TryParse("World", out symbol3);
Console.WriteLine(isParse4); //False
Console.WriteLine(symbol3);

DateTime date2;
var isParse5 = DateTime.TryParse("26.06.2022", out date2);
Console.WriteLine(isParse5); //True
Console.WriteLine(date2);

DateTime date3;
var isParse6 = DateTime.TryParse("26062022", out date3);
Console.WriteLine(isParse6); //True
Console.WriteLine(date3);

//Метод Parse возвращает преобразованное число;
//метод TryParse возвращает логическое значение, которое указывает, успешно ли выполнено преобразование,
//и возвращает преобразованное число в параметр out . Если строка имеет недопустимый формат,
//Parse создает FormatException, а TryParse возвращает значение false.
//Поэту TryParse лучше, т.к. не бросает FormatException