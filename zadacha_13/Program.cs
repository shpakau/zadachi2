// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// 645
Console.WriteLine("Задача 13");
Console.Write("Введите число из условия задачи:");
int treeNumber = Convert.ToInt32(Console.ReadLine());
string treeNumberRead = Convert.ToString(treeNumber);
if (treeNumberRead.Length > 2)
{
    Console.WriteLine("третья цифра этого числа = " + treeNumberRead[2]);
}
    else 
    {
        Console.WriteLine(" - третьей цифры нет в заданном числе.");
    }

// 78
Console.Write("Введите число из условия задачи:");
int tree2Number = Convert.ToInt32(Console.ReadLine());
string tree2NumberRead = Convert.ToString(tree2Number);
if (tree2NumberRead.Length > 2)
{
    Console.WriteLine("третья цифра этого числа = " + tree2NumberRead[2]);
}
    else 
    {
        Console.WriteLine(" - третьей цифры нет в заданном числе.");
    }

// 32679
Console.Write("Введите число из условия задачи:");
int tree3Number = Convert.ToInt32(Console.ReadLine());
string tree3NumberRead = Convert.ToString(tree3Number);
if (tree3NumberRead.Length > 2)
{
    Console.WriteLine("третья цифра этого числа = " + tree3NumberRead[2]);
}
    else 
    {
        Console.WriteLine(" - третьей цифры нет в заданном числе.");
    }
/////////
Console.WriteLine("Конец)");