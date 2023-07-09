// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
double Distanse3D(int x1, int y1, int x2, int y2, int z1, int z2)
{
    double distanceSquared = ((double)Math.Pow((x2 - x1), 2) +  (double)Math.Pow((y2 - y1), 2) + (double)Math.Pow((z2 - z1),2));
    double result = Math.Sqrt(distanceSquared);
    return Math.Round(result,2);
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = GetInfo("Введите координату X1: "); 
int y1 = GetInfo("Введите координату Y1: "); 
int z1 = GetInfo("Введите координату Z1: "); 
int x2 = GetInfo("Введите координату X2: "); 
int y2 = GetInfo("Введите координату Y2: "); 
int z2 = GetInfo("Введите координату Z2: ");  

Console.WriteLine($"A {(x1, y1, z2)}; B {(x2, y2, z2)} - > {(Distanse3D(x1, y1, x2, y2, z1, z2))}");

