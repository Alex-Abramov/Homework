/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
Строчку с равенством было интересно попробовать и я решил добавить :)
*/

/*
Console.WriteLine("Input numA ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input numB ");
int numB = Convert.ToInt32(Console.ReadLine());
if (numA < numB) Console.WriteLine($"{numB} > {numA}");
if (numA > numB) Console.WriteLine($"{numB} < {numA}");
if (numA == numB) Console.WriteLine($"{numB} = {numA}");
*/

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
/*
Console.WriteLine("Input numA ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input numB ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input numC ");
int numC = Convert.ToInt32(Console.ReadLine());
int Max = 0;
if (numA < numB)
{
    Max = numB;
}
if (numB < numC)
{
    Max = numC;
}
if (numC < numA)
{
    Max = numA;
}
Console.WriteLine(Max);
*/

/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
/*
Console.WriteLine("Input numA ");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = 2;
int result = numA % numB;
if (result > 0) Console.WriteLine($"Число без остатка не делится {result}");
if (result == 0) Console.WriteLine($"Число делится без остатка {result}");
*/

/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
/*
Console.WriteLine("Input numA ");
int numA = Convert.ToInt32(Console.ReadLine());
int current = 0;
while (current <= numA)
{
    Console.WriteLine(current + " ");
current = current + 2;
}
*/



