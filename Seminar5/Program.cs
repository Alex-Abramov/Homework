/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
/*
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
        Console.Write(array[i] + " ");
    }
}

int ElementsCount(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Введите размер массива ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
int result = ElementsCount(myArray);
Console.WriteLine($"В этом массиве содержится {result} четных элементов");
*/
/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
/*
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
        Console.Write(array[i] + " ");
    }
}

void FindOddPositionSum(int[] array)
{
    int oddPositionSum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0 ) oddPositionSum += array[i];
    }
    Console.WriteLine($"Сумма элементов, находящихся на чётных позициях -> {oddPositionSum}");
}

Console.WriteLine("Введите размер массива ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
FindOddPositionSum(myArray);
*/
/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
/*
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

void FindMinMaxDifference(int[] array)
{
    int difference = 0;
    int maxElement = 0;
    int minElement = 0;
    for(int i = 0; i < array.Length; i++)
    {   
        if(array[i] > maxElement)
        {
            maxElement = array[i];
            if(array[1] < minElement) minElement = array[i];
        }
        else minElement = array[i];
        difference = maxElement - minElement;
    }
    Console.WriteLine($"Разница макимального и минимального элементов массива равна -> {difference}");
}

Console.WriteLine("Введите размер массива ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
FindMinMaxDifference(myArray);
*/
