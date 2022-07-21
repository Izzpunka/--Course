// Задача 3: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр. Использовать рекурсию.
// 453 -> 12
// 45 -> 9

int NumbersSum(int number)
{

    if (number == 0) return 0;
    return NumbersSum(number / 10) + number % 10;
}

Console.WriteLine(NumbersSum(453));
