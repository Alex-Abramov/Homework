/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
/*
void ShowNumbers(int n)
{
    if(n < 0)
    {
        Console.WriteLine("Не является натуральным числом");
    }
    if(n > 0) 
    {
        Console.Write(n + " ");
        ShowNumbers(n-1);
    }
}

ShowNumbers(-5);
*/
/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/*
int NumbersSum(int m, int n)
{   
    int start = m;
    int finish = n;
    if(m != n)
    {
        start = m;
        finish = n;
    }
    return (finish + start) * (finish - start + 1) / 2;
}

Console.WriteLine(NumbersSum(1, 2));
*/
/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
/*
int Akkerman(int m, int n)
{
    if(m == 0) return n + 1;
    if(m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.WriteLine(Akkerman(4, 4));
*/
