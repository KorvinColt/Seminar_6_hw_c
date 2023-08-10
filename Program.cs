// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел: ");
int M = int.Parse(Console.ReadLine());

int countPositive = 0; // Счетчик положительных чисел

for (int i = 0; i < M; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    int number = int.Parse(Console.ReadLine());

    if (number > 0)
    {
        countPositive++;
    }
}

Console.WriteLine($"Количество чисел больше 0: {countPositive}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите значение b1: ");
double b1 = double.Parse(Console.ReadLine());

Console.Write("Введите значение k1: ");
double k1 = double.Parse(Console.ReadLine());

Console.Write("Введите значение b2: ");
double b2 = double.Parse(Console.ReadLine());

Console.Write("Введите значение k2: ");
double k2 = double.Parse(Console.ReadLine());

// Находим значение x для точки пересечения прямых
double x = (b2 - b1) / (k1 - k2);

// Вычисляем соответствующее значение y
double y = k1 * x + b1;

Console.WriteLine($"Точка пересечения: ({x}; {y})");
