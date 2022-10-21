/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

/*
int AmountNummers(int size)
{   
    int amount = 0;
    for(int i = 0; i < size; i++)
    {
    Console.WriteLine("Input number ");
    int num = Convert.ToInt32(Console.ReadLine());
    if(num > 0) amount++;
    }
    return amount; 
}

Console.WriteLine("How much numbers do you have? ");
int size = Convert.ToInt32(Console.ReadLine());
int result = AmountNummers(size);
Console.WriteLine($"You have -> {result} positive numbers.");
*/
/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

void FindPoint(double b1, double k1, double b2, double k2)
{   
    double x = (b1 - b2) / (k1 - k2);
    double y = (k2 * b1 - k1 * b2) / ( k2 - k1);
    if(k1 == k2) Console.WriteLine("Coordinates do not intersect");
    else Console.WriteLine($"Coordinates intersect in point ({x};{y})");
}

Console.WriteLine("Input b1:");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input k1 :");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input b2:");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input k2:");
double k2 = Convert.ToDouble(Console.ReadLine());

FindPoint(b1, k1, b2, k2);