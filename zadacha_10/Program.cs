// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру
// этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// 456
Console.WriteLine("Задача 10");
Console.Write("Введите трехзначное число из условия:");
int threeNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeNumber);
// 782
Console.WriteLine("Вторая цифра этого числа = " + stringNumber[1]);
Console.Write("Введите трехзначное число из условия:");
int three2Number = Convert.ToInt32(Console.ReadLine());
string string2Number = Convert.ToString(three2Number);
// 918
Console.WriteLine("Вторая цифра этого числа = " + stringNumber[1]);
Console.Write("Введите трехзначное число из условия:");
int three3Number = Convert.ToInt32(Console.ReadLine());
string string3Number = Convert.ToString(three3Number);
Console.WriteLine("Вторая цифра этого числа = " + string3Number[1]);
////////
Console.WriteLine("Конец)");