/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
/*
double DegreeNumber(double a, double b)
{
    return Math.Pow(a, b);
}

Console.WriteLine("Input number ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input degree of number ");
double b = Convert.ToDouble(Console.ReadLine());

double result = DegreeNumber(a, b);
Console.WriteLine($"Degree is {result}");
*/
/*
double DegreeNumber (double a, double b)
{   
    double degree = 0;
    for(double i = 0; i <= a; i++)                                                                  //тоже задача №25, просто попробовал добавить for, как говорила Анастасия.
    {
        degree = Math.Pow(a, b);
    }
    return degree;
}

Console.WriteLine("Input number ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input degree of number ");
double b = Convert.ToDouble(Console.ReadLine());

double result = DegreeNumber(a, b);
Console.WriteLine($"Degree is {result}");
*/
/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
/*
int SumDiggitsOfNumber(int num)
{   
    int size = Convert.ToString(num).Length;
    int ed = 0;
    int diggitsSum = 0;
    for(int i = 0; i < size; i++)
    {   
        ed = num - num % 10;
        diggitsSum = diggitsSum + (num - ed);
        num = num / 10;

    }
    return diggitsSum;
}

Console.WriteLine("Input number ");
int num = Convert.ToInt32(Console.ReadLine());

int sumDiggitsOfNumber = SumDiggitsOfNumber(num);
Console.WriteLine(sumDiggitsOfNumber);
*/
/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] myArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue + 1);
    }                                                                                                               
    return myArray;
}

void ShowArray(int[] array)
{
    Console.WriteLine("Получившийся массив -> ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
    }
}

Console.WriteLine("Введите размер массива ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);