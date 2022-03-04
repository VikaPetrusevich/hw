// See https://aka.ms/new-console-template for more information
sbyte value = 105;
SByte value2 = 96;
Console.WriteLine(value.GetType());
Console.WriteLine(value2.GetType());

short value3 = -2_586;
Int16 value4 = 486;
Console.WriteLine(value3.GetType());
Console.WriteLine(value4.GetType());

int value5 = 249_854;
Int32 value6 = 895_597;
Console.WriteLine(value5.GetType());
Console.WriteLine(value6.GetType());

long value7 = 265_865_815;
Int64 value8 = 68_455;
Console.WriteLine(value7.GetType());
Console.WriteLine(value8.GetType());

byte value9 = 196;
Byte value10 = 52;
Console.WriteLine(value9.GetType());
Console.WriteLine(value10.GetType());

ushort value11 = 16_258;
UInt16 value12 = 48_754;
Console.WriteLine(value11.GetType());
Console.WriteLine(value12.GetType());

char value13 = 'V';
Char value14 = 'C';
Console.WriteLine(value13.GetType());
Console.WriteLine(value14.GetType());

uint value15 = 695_589_495;
UInt32 value16 = 69_485;
Console.WriteLine(value15.GetType());
Console.WriteLine(value16.GetType());

ulong value17 = 95_885_559;
UInt64 value18 = 984_455_585;
Console.WriteLine(value17.GetType());
Console.WriteLine(value18.GetType());

float value19 = 15.864F;
Single value20 = 1.892156F;
Console.WriteLine(value19.GetType());
Console.WriteLine(value20.GetType());

double value21 = 0.85654255;
Double value22 = 15.982355565;
Console.WriteLine(value21.GetType());
Console.WriteLine(value22.GetType());

decimal value23 = 1.865222M;
Decimal value24 = 12.9852325255M;
Console.WriteLine(value23.GetType());
Console.WriteLine(value24.GetType());

object obj = new object();
Object obj2 = new object();
Console.WriteLine(obj.GetType());
Console.WriteLine(obj2.GetType());

string greeting = "Hello!";
String greeting2 = "Hi!";
Console.WriteLine(greeting.GetType());
Console.WriteLine(greeting2.GetType());

Console.ReadKey();

