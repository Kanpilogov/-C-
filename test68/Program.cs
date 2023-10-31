// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите натуральное число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

if (numM < 0 || numN < 0)
{
    Console.WriteLine("Нельзя вводить отрицателое число");
    return;
}


int FAck(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return FAck(m - 1, 1);
    return FAck(m - 1, FAck(m, n - 1));
}

int result = FAck(numM, numN);
Console.WriteLine($"m={numM}, n={numN}-> A(m,n) = {result}");

