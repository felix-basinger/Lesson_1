// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int num;
Console.Write("Enter a number: ");
int.TryParse(Console.ReadLine(), out num);

if(num % 2 == 0)
{
    Console.WriteLine("Yes, it's even number.");
}
else
{
    Console.WriteLine("No, it's not even number.");
}