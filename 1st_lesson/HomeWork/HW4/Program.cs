//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());

if (n1<n2)
{
    n1=n2;
}
if(n1<n3)
{
    n1=n3;
}
Console.WriteLine($"The number {n1} is the largest");