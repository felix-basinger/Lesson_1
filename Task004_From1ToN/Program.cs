// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int N;
Console.Write("Enter the number N: ");
int.TryParse(Console.ReadLine(), out N);

for(int i = 2; i <= N; i += 2)
{
    Console.Write(i);
    Console.Write(", ");
}
