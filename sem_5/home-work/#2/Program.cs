/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/



int[] arrayGenerator(int size = 10)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-999,999);
    }
    return arr;
}

int oddSum(int[] arr)
{
    int oddSum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            oddSum += arr[i];
        }
    }
    return oddSum;
}

void printResult()
{
    int size = new Random().Next(3,99);
    int[] arr = arrayGenerator(4);
    Console.WriteLine("Исходный массив: [" + String.Join(", ", arr) + "]");
    Console.WriteLine("Сумма элементов на нечетных позициях: " + oddSum(arr));
}
printResult();