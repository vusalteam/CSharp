/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] randomArray(int rows = 5, int columns = 4)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-99,100);
        }
    }
    return array;
}
void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int? checkValueByIndexes(int[,] array, int row, int column)
{
    if (row < 0 || row >= array.GetLength(0) || column < 0 || column >= array.GetLength(1))
        return null;
    return array[row, column];
}


int[,] array = randomArray(2, 1);
printArray(array);
Console.WriteLine("Введите № строки: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите № столбца: ");
int column = int.Parse(Console.ReadLine());
int? value = checkValueByIndexes(array, row, column);
if (value == null)
    Console.WriteLine("такого числа в массиве нет");
else
    Console.WriteLine($"Значение: {value}");

