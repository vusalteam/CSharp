/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] arr = new int[4, 4];
int num = 1;
int rowStart = 0, rowEnd = 3, colStart = 0, colEnd = 3;

while (rowStart <= rowEnd && colStart <= colEnd)
{
    // заполнение верхней строки
    for (int i = colStart; i <= colEnd; i++)
    {
        arr[rowStart, i] = num;
        num++;
    }
    rowStart++;

    // заполнение правого столбца
    for (int i = rowStart; i <= rowEnd; i++)
    {
        arr[i, colEnd] = num;
        num++;
    }
    colEnd--;

    // заполнение нижней строки
    for (int i = colEnd; i >= colStart; i--)
    {
        arr[rowEnd, i] = num;
        num++;
    }
    rowEnd--;

    // заполнение левого столбца
    for (int i = rowEnd; i >= rowStart; i--)
    {
        arr[i, colStart] = num;
        num++;
    }
    colStart++;
}

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write("{0:D2} ", arr[i, j]);
    }
    Console.WriteLine();
}