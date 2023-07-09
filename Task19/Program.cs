// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


void Polindrom (int num)
{
    int digit1 = num / 10000;
    int digit2 = (num / 1000) % 10;
    int digit4 = (num / 10) % 10;
    int digit5 = num % 10;
    
    if(digit1 == digit5 && digit2 ==digit4)
    {
        Console.Write($"{num} -> да");
    }
    else
    {
        Console.Write($"{num} -> нет");
    }
}

int Getinfo (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num = Getinfo("Введите пятизначное число: ");
Polindrom(num);