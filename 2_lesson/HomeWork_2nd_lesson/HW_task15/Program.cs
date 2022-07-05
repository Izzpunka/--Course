// 4. Напишите программу, которая принимает на вход цифру,
//    обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Enter the number");
void Week(int num)
{
    string text = "no, it`s labour day!";

    if (num == 7 || num == 6) text = "yes";
    if (num > 7) text = "Enter the number which is less than 7";
    Console.WriteLine($"{num} -> {text}");
}

Week (int.Parse(Console.ReadLine()));
