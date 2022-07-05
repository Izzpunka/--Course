// 3. Напишите программу, которая выводит третью цифру
//    заданного числа или сообщает, что третьей цифры нет.

void ThirdNum(int num)
{
    Console.Write($"{num} -> ");
    if (num < 99)
    {
        Console.WriteLine("there is no third digit");
        return;
    }

    while (num > 999) num = num / 10;
    Console.WriteLine(num % 10);
}

ThirdNum(int.Parse(Console.ReadLine()));



ThirdNum(641);
ThirdNum(32879);
ThirdNum(32079);
ThirdNum(78);