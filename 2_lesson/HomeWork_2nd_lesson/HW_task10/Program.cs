// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5

Console.WriteLine("Введите трехзначное число");
string userData = Console.ReadLine();
int userNumber = Convert.ToInt32(userData);
int secondNumber(int userNumber)
{
return userNumber/10 % 10;
}
Console.WriteLine("Вторая цифра:" + secondNumber(userNumber));
