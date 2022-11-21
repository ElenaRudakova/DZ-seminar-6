// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, 
// k2 = 9 -> (-0,5; -0,5)
void Coordinates(int A1, int B1, int A2, int B2)
{
    if (B1 == B2)
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
        int x = (A2 - A1) / (B1 - B2);
        int y = A1 * x + B1;
        Console.WriteLine($"Пересечение в точке: ({x};{y})");
    }
}
Console.Clear();
Console.WriteLine("Введите b1: ");
int b1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k1: ");
int k1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите b2: ");
int b2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k2: ");
int k2 = int.Parse(Console.ReadLine()!);
Coordinates(b1, k1, b2, k2);