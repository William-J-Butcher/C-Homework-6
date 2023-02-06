// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// double b1 = 2;
// double b2 = 4;
// double k1 = 5;
// double k2 = 9;

// double x = (b2 - b1) / (k1 - k2);
// double y = k2 * x + b2;
// Console.WriteLine(x);
// Console.WriteLine(y);




void GetXY(double b1, double b2, double k1, double k2)
{
    double x = Convert.ToDouble((b2 - b1) / (k1 - k2));
    double y = Convert.ToDouble(k2 * x + b2);
    Console.WriteLine(x);
    Console.WriteLine(y);
}

Console.Write("Введите переменную 'b1': ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите переменную 'b2': ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите переменную 'k1': ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите переменную 'k2': ");
int k2 = Convert.ToInt32(Console.ReadLine());

GetXY(b1, b2, k1, k2);