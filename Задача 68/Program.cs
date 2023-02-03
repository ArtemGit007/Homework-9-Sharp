// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 9
// m = 3, n = 2->A(m, n) = 29

using System;
using static System.Console;

int M = AskNumber("M");
int N = AskNumber("N");
WriteLine($"M = {M}; N = {N} -> A(m,n) = {Akerman(M, N)}");

static int Akerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
        if ((n != 0) && (m == 0))
        return Akerman(n - 1, 1);
    else
        return Akerman(n - 1, Akerman(n, m - 1));
}

static int AskNumber(string name)
{
    Write($"Введите число {name}: ");
    return int.Parse(ReadLine());
}
