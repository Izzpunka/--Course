// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void CreateMas(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

double[] MassNumbers(int size)
{
    double[] arr = new double[size];
    Random n_new = new Random();

    for (int i = 1; i < size; i++)
    {
        arr[i] = Math.Round(n_new.NextDouble() * (10 + 12) - 10, 2);
    }
    return arr;
}

void DifferenceMaxMin(double[] arr)
{
    double maxnum = arr[0];
    double minnum = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (maxnum < arr[i])
        {
            maxnum= arr[i];
        }
        else if (minnum > arr[i])
        {
            minnum = arr[i];
        }
    }
    Console.Write($"Maximal number: {maxnum}, minimal number: {minnum}. ");
    Console.WriteLine($"Difference between max and min = {maxnum} - ({minnum}) = {Math.Round(maxnum - minnum, 2)}");
}

double[] arr_1 = MassNumbers(8);
CreateMas(arr_1);
DifferenceMaxMin(arr_1);
