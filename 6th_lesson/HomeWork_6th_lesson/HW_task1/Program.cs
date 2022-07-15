// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int CountingNumbers(int howManyNumbers)
{
    int count = 0;
    for (int i = 1; i<=howManyNumbers; i++)
    {
        Console.Write($"Enter number {i}- ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());
        if (inputNumber>0) count++;
    }
    return count;
}

Console.WriteLine("Please inform us how namy numbers are you going to enter?");
int howManyNumbers = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Please enter your {howManyNumbers} numbers!");
// int inputNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The quantity of numbers bigger than 0: {CountingNumbers(howManyNumbers)}.");