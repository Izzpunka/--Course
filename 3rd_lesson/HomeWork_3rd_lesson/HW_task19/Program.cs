// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

void Palindrome(int n)
{
    int i = 0;
    string num = n.ToString();
    int size = num.Length - 1;
    string palindrome = "yes, it`s palindrome";
    
    while (i < size / 2)
    {
        if (num[i] != num[size - i]) 
        {
            palindrome = "no";
            break;
        }        
        i += 1;
    }    
    Console.WriteLine($"{n} -> {palindrome}");
}

Palindrome(54345);