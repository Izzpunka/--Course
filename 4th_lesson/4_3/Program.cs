// 2. Напишите программу, которая принимает на вход
//    число N и выдаёт произведение чисел от 1 до N.

int PowNum(int num)
{
    int all_sum = 1;
    for (int i = 1; i <= num; i++)
    {
        all_sum *= i;
    }
    return all_sum;
}

Console.WriteLine(PowNum(4));
Console.WriteLine(PowNum(5));
Console.WriteLine(PowNum(11));