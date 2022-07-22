// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

Console.Write("Please enter M (It should be > 0): ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter N (It should be > 0): ");
int N = Convert.ToInt32(Console.ReadLine());

void ShowEvens(int M, int N)
{
    if (N % 2 == 1) N = N - 1;

    if (N < M) return;
    ShowEvens(M, N - 2);
    Console.Write($"{N} ");
}
ShowEvens(M, N);

