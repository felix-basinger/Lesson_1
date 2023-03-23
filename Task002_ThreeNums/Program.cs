// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a;
Console.Write("Enter a number 'a': ");
int.TryParse(Console.ReadLine(), out a);

int b;
Console.Write("Enter a number 'b': ");
int.TryParse(Console.ReadLine(), out b);

int c;
Console.Write("Enter a number 'c': ");
int.TryParse(Console.ReadLine(), out c);

int max = a;

if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;

Console.WriteLine("max = " + max);