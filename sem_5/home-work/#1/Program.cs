/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/


int[] arrayGenerator(int size = 10)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100,999);
    }
    return arr;
}

int evenSize(int[] arr)
{
    int even = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            even++;
        }
    }
    return even;
}

int oddSize(int[] arr)
{
    int odd = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 != 0)
        {
            odd++;
        }
    }
    return odd;
}

void printResult()
{
    int size = new Random().Next(3,99);
    int[] arr = arrayGenerator(size);
    Console.WriteLine("Исходный массив: [" + String.Join(", ", arr) + "]");
    Console.WriteLine("Количество чётных чисел в массиве: " + evenSize(arr));
    Console.WriteLine("Количество нечётных чисел в массиве: " + oddSize(arr));
}
printResult();