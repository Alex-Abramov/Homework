/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
/*
int SecondDigitOfNumber(int num)
{
    int ed = num % 10;
    int hundred = num / 100;
    int currentSum = hundred * 100 + ed;
    int result = (num - currentSum) / 10;
    return result;
}

Console.WriteLine("Input number  ");                                         
int num = Convert.ToInt32(Console.ReadLine());
int result = SecondDigitOfNumber(num);
Console.WriteLine($"-> {result}");
*/
/*
int SecondDigitOfNumber(int num)
{
    int ed = num % 10;
    int hundred = num / 100;
    int currentSum = hundred * 100 + ed;
    int result = (num - currentSum) / 10;
    return result;                                                              // Это всё та же задача №10, просто сделал через RandomNumber
}

int RandomNumber = new Random().Next(100, 1000);

int result = SecondDigitOfNumber(RandomNumber);
Console.WriteLine($"{RandomNumber} -> {result}");
*/

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
/*
void SecondIndexOfNumber(int num)
{
    if (num >= 100)
       Console.WriteLine($"-> {num.ToString()[2]}");
    else 
        Console.WriteLine("-> Третьей цифры нет");
}

Console.WriteLine("Input number  ");
int num = Convert.ToInt32(Console.ReadLine());

SecondIndexOfNumber(num);
*/

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
/*
bool NeedlyDigit(int num)
{
    if (num > 5)
    return true;
    else
    return false;
}

Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());

bool WeekendDayDigit = NeedlyDigit(num);
Console.WriteLine(WeekendDayDigit);
*/