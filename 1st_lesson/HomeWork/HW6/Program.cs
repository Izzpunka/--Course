// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

int n1 = int.Parse(Console.ReadLine());
if (n1 % 2 == 0)
{
    Console.WriteLine($"The number {n1} is even.");
}
else
{
Console.WriteLine($"The number {n1} is odd.");    
}