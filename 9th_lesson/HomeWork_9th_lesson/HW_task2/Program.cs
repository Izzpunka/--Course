// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int ElementsSum(int M, int N)
{
  
    if (N < M) return 0; 
    else return N + ElementsSum(M, N - 1);
}

Console.WriteLine(ElementsSum(4, 8));
Console.WriteLine(ElementsSum(1, 15));
