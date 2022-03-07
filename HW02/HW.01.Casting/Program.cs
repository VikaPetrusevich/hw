// See https://aka.ms/new-console-template for more information
// implicit conversion
byte number = 10; 
short number2 = number;
Console.WriteLine(number2);

int number3 = 2698;
long number4 = number3;
Console.WriteLine(number4);

sbyte number5 = -56;
int number6 = number5;
Console.WriteLine(number6);

long number7 = 568_452;
decimal number8 = number7;
Console.WriteLine(number8);

float number9 = 45.847F;
double number10 = number9;
Console.WriteLine(number10);

// explicit conversion
ushort number11 = 156;
byte number12 = (byte)number11;
Console.WriteLine(number12);

float number13 = 847.654F;
int number14 = (int)number13;
Console.WriteLine(number14);

int number15 = 214;
byte number16 = (byte)number15;
Console.WriteLine(number16);

decimal number17 = 14.5874155874M;
float number18 = (float)number17;
Console.WriteLine(number18);

long number19 = 25_585;
short number20 = (short)number19;
Console.WriteLine(number20);

//boxing
int valueType = 100;
object referenceType = valueType;
Console.WriteLine(referenceType);

short valueType2 = 654;
object referenceType2 = valueType2;
Console.WriteLine(referenceType2);

float valueType3 = 49.64515F;
object referenceType3 = valueType3;
Console.WriteLine(referenceType3);

long valueType4 = 54_154_666;
object referenceType4 = valueType4;
Console.WriteLine(referenceType4);

decimal valueType5 = 45.5586874M;
object referenceType5 = valueType5;
Console.WriteLine(referenceType5);

// unboxing
object referenceType6 = 45;
int valueType6 = (int)referenceType6;
Console.WriteLine(valueType6);

object referenceType7 = 185.69756445M;
decimal valueType7 = (decimal)referenceType7;
Console.WriteLine(valueType7);

object referenceType8 = -25;
int valueType8 = (int)referenceType8;
Console.WriteLine(valueType8);

object referenceType9 = 367.4482656F;
float valueType9 = (float)referenceType9;
Console.WriteLine(valueType9);

object referenceType10 = 695_565_484L;
long valueType10 = (long)referenceType10;
Console.WriteLine(valueType10);
Console.ReadKey();