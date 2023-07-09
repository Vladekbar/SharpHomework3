// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Cube (int num)
{
    Console.Write($"{num} - > "); 
    for (int i = 1; i < num; i++)
    {
      Console.Write((int)Math.Pow(i, 3) + ", ");  
    }
    Console.Write((int)Math.Pow(num, 3) + ".");
}

int Getinfo (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num = Getinfo("Введите число: ");
Cube(num);