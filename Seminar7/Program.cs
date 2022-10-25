/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
/*
int [,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue, int a, int b)
{
    int[,] newArray = new int[rows, columns];                        
    for(int i = 0; i < rows; i++)                                   
        for(int j = 0; j < columns; j++)                             
        {
            newArray[i,j] = new Random().Next(minValue, maxValue +1);
        }
        return newArray;
}

void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++) 
    {                                   
        for(int j = 0; j < array.GetLength(1); j++)                             
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();}
}

int[,] ShowNumber(int[,] array, int a, int b)                                      
{   
    object ourNumber = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++) 
        {
            if(a > array.GetLength(0) && b > array.GetLength(1))
            {
                Console.WriteLine("Число по указанным координатам отсутствует");  // Архип, посмотрите, пожалуйста. У меня автоматически ПК выдает, что индекс отсутсвует, если он указан в строке или столбце больше, чем вмещает в себя массив.(Т.Е. автоматом же выдаст, что число не будет найдено). При всём этом, если координаты по горизонтали указать больше одновременно с координатами по вертикали, то выдаст ответ, прописанный в коде.
            }                                                               // Вообщем, благодаря GetValue, задача решается, но не совсем так, как это запрашивается в условии.
            else 
            {
                ourNumber = array.GetValue(a,b);
            }
        }
    }   
    Console.WriteLine($"Число, которое расположено по указанным координатам -> {ourNumber}");
    return array;                                                                 
}

Console.WriteLine("Введите количество строк:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное значение:");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное значение:");
int maxValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение по вертикали:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение по горизонтали:");
int b = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DRandomArray(m, n, minValue, maxValue, a, b);
Console.WriteLine();
Show2DArray(ShowNumber(myArray, a, b));
*/
/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
/*
int [,] Create2DRandomArray(int minValue, int maxValue)
{
    int[,] newArray = new int[3, 3];                        
    for(int i = 0; i < 3; i++)                                   
        for(int j = 0; j < 3; j++)                             
        {
            newArray[i,j] = new Random().Next(minValue, maxValue +1);
        }
        return newArray;
}

void Show2DArray(int[,] array)
{
    for(int i = 0; i < 3; i++) 
    {                                   
        for(int j = 0; j < 3; j++)                             
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();}
}

void Average(int[,] array)
{   
    
    for(int j = 0; j < 3; j++)  
    {   
        int sum = 0;                                
        for(int i = 0; i < 3; i++)                             
        {
            sum += array[i,j]; 
        }
        Console.WriteLine();
        Console.WriteLine($"Cреднее арифметическое элементов столбца {j + 1} = {(float)sum / 3}");
    }                        
}

Console.WriteLine("Введите минимальное значение:");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное значение:");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DRandomArray(minValue, maxValue);
Show2DArray(myArray);                                                      
Average(myArray);
*/