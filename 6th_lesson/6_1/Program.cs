// 1. Напишите программу, которая принимает на вход три числа
//    и проверяет, может ли существовать треугольник с сторонами такой длины.

void Triangle (int num1, int num2, int num3)
{
    if(num1+num2>num3 && num1+num3>num2 && num2+num3>num1) 

Console.WriteLine($"Triangle exists");

else
{
    Console.WriteLine("Triangle doesn`t exist"); 
}
}

Triangle(5,6,3);

