// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Enter number А");
string inputA = Console.ReadLine();
int a = Convert.ToInt32(inputA);
Console.WriteLine("Enter number B");
string inputB = Console.ReadLine();
int b = Convert.ToInt32(inputB);

int naturStepen(int a, int b)
{
    int result = a;
    for (int i = 2; i <= b; i++)
    {
        result *= a;
    }
    return result;
}

Console.WriteLine($"Result = {naturStepen(a,b)}");