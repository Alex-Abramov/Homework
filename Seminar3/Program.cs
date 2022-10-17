/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
/*
Console.Write("Input number ");
string? number = Console.ReadLine();

void PolindromeNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"{number} -> Yes.");
  }
  else Console.WriteLine($"{number} -> No");
}

if (number!.Length == 5)
{
  PolindromeNumber(number);
}
else Console.WriteLine($"{number} -> Number uncorrect. Try with 5 digits legth number");
*/


/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
/*
void Cube(int number)
{
    int step = 1;
    while (step <= number)
    {
        Console.WriteLine($"Cube of the number {step} equals {step * step * step}");
        step++;
    }
    
}
Console.WriteLine("Input number ");
int number = Convert.ToInt32(Console.ReadLine());

Cube(number);
*/
/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double FindDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
   return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}

Console.WriteLine("Input x1:");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input y1:");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input z1:");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input x2:");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input y2:");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input z2:");
double z2 = Convert.ToDouble(Console.ReadLine());

double findDistance = FindDistance(x1, y1, z1, x2, y2, z2);

Console.WriteLine($"Distance ={findDistance} ");