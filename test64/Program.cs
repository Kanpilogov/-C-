// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.WriteLine("Введите  натуральное число: ");
int numberM = Convert.ToInt32(Console.ReadLine());


if(numberM < 1 )
{
    Console.WriteLine("Некорректный ввод!");
    return;
}

PrintRangeNaturalNumbers(numberM);

void PrintRangeNaturalNumbers(int numM)
{
    if (numM < 1)
    {
        Console.Write($"{numM} ");
        PrintRangeNaturalNumbers(numM + 1);
    }

    else if (numM > 1)
    {
        Console.Write($"{numM} ");
        PrintRangeNaturalNumbers(numM - 1);
    }
    else Console.Write($"{numM} ");
}