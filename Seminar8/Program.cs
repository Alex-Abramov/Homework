/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
/*
int [,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
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

int[,] ElementsFromMaxToMin(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if(array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
        
    }
    return array;
}

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DRandomArray(m,n,min,max);
Show2DArray(myArray);
myArray = ElementsFromMaxToMin(myArray);
Console.WriteLine();
Show2DArray(myArray);
*/
/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
/*
int [,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
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

int SumElementsFromRow(int[,] array, int i)
{
    int rowSum = array[i, 0];
    for(int j = 1; j < array.GetLength(1); j++)
    {
        rowSum += array[i, j];
    }
    return rowSum;
}

int[,] RowWithlowlestSum(int[,] array)
{
    int minSumRow = 0;
    int rowSum = SumElementsFromRow(array, 0);
    for(int i = 1; i < array.GetLength(0); i++)
    {
        int tempRowSum = SumElementsFromRow(array, i);
        if(rowSum > tempRowSum)
        {
            rowSum = tempRowSum;
            minSumRow = i;
        }
        else Console.WriteLine($"\n{minSumRow + 1} - строкa с наименьшей суммой. Сумма элементов в указанной строке -> {rowSum} ");
    }
    return array;
}

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DRandomArray(m,n,min,max);
Show2DArray(myArray);
myArray = RowWithlowlestSum(myArray);
Console.WriteLine();
*/
/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/


Console.WriteLine("Введите x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z: ");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"");

int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
WriteArray(array3D);

void WriteArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}

