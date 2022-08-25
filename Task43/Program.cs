// Задача 43: Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void CommonPointLines (double b1, double k1, double b2, double k2)
{
    if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельные.");
        return;
    }  
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    // Console.WriteLine(x);
    // Console.WriteLine(y);
    Console.WriteLine($"Точка пересечения двух прямых ({x}; {y}).");
}

Console.WriteLine("Введите значение b1 и нажмите Enter.");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k1 и нажмите Enter.");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2 и нажмите Enter.");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2 и нажмите Enter.");
double k2 = Convert.ToDouble(Console.ReadLine());
CommonPointLines (b1, k1, b2, k2);