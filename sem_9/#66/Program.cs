/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.Write("Задайте значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

int getSum(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    else
    {
        return m + getSum(m + 1, n);
    }
}

int sum = getSum(m, n);
Console.WriteLine($"Сумма элементов в промежутке от {m} до {n} = {sum}");