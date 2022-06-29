//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

string s_n_1 = Console.ReadLine();
string s_n_2 = Console.ReadLine();

int n1 = int.Parse(s_n_1);
int n2 = int.Parse(s_n_2);

if (n1 > n2)
{
Console.WriteLine($"The number {n1} is bigger than {n2}");
}
else if (n1 == n2)
{
Console.WriteLine($"The number {n1} is equal t0 {n2}");
}
else
{
    Console.WriteLine($"The number {n2} is bigger than {n1}");
}