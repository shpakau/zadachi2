// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// 6 -> да
Console.WriteLine("Задача 15");
Console.Write("Введите число, согласно условию задачи, обозначающее день недели:");
int dayNumber = Convert.ToInt32(Console.ReadLine());
void CheckingTheDayOfTheWeek (int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("(этот день недели выходной) - да");
    }
        else if (dayNumber < 1 || dayNumber > 7)
        {
            Console.WriteLine("будьте внимательнее, в неделе 7 (семь) дней");
        }
    else Console.WriteLine("(это рабочий день, не выходной) - нет");
}
CheckingTheDayOfTheWeek(dayNumber);

// 7 -> да
Console.Write("Введите число, согласно условию задачи, обозначающее день недели:");
int day2Number = Convert.ToInt32(Console.ReadLine());
void CheckingTheDayOfTheWeek2 (int day2Number)
{
    if (day2Number == 6 || day2Number == 7)
    {
        Console.WriteLine("(этот день недели выходной) - да");
    }
        else if (day2Number < 1 || day2Number > 7)
        {
            Console.WriteLine("будьте внимательнее, в неделе 7 (семь) дней");
        }
    else Console.WriteLine("(это рабочий день, не выходной) - нет");
}
CheckingTheDayOfTheWeek2(day2Number);

// 1 -> нет
Console.Write("Введите число, согласно условию задачи, обозначающее день недели:");
int day3Number = Convert.ToInt32(Console.ReadLine());
void CheckingTheDayOfTheWeek3 (int day3Number)
{
    if (day3Number == 6 || day3Number == 7)
    {
        Console.WriteLine("(этот день недели выходной) - да");
    }
        else if (day3Number < 1 || day3Number > 7)
        {
            Console.WriteLine("будьте внимательнее, в неделе 7 (семь) дней");
        }
    else Console.WriteLine("(это рабочий день, не выходной) - нет");
}
CheckingTheDayOfTheWeek3(day3Number);
////////
Console.WriteLine("Конец)");