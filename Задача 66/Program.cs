// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число М:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());

int Sum(int M, int N)
{
    if (M > N)
    {
        return 0;
    }
    return M + Sum(M + 1, N);
}

Console.WriteLine($"M = {M}; N = {N} -> {Sum(M, N)}");

