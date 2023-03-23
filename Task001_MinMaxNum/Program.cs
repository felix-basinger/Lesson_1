// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int a;
Console.Write("Enter a number 'a': ");
int.TryParse(Console.ReadLine(), out a);

int b;
Console.Write("Enter a number 'b': ");
int.TryParse(Console.ReadLine(), out b);

int min = 0;
int max = 0;

if(a > b)
{
    max = a;
    min = b;
    Console.WriteLine("max number = " + max);
    Console.WriteLine("min number = " + min);
}
else if(a < b)
{
    max = b;
    min = a;
    Console.WriteLine("max number = " + max);
    Console.WriteLine("min number = " + min);
}
else
{
    Console.WriteLine(a + " = " + b);
}