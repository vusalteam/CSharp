/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double[] arrayGenerator(int size = 10)
{
    double[] arr = new double[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(new Random().NextDouble()*1000, 2);
    }
    return arr;
}

double getMin(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}
double getMax(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}


void printResult()
{
    int size = new Random().Next(3,99);
    double[] arr = arrayGenerator(size);
    Console.WriteLine("Исходный массив: [" + String.Join(", ", arr) + "]");
    double min = getMin(arr);
    double max = getMax(arr);
    Console.WriteLine("Максимальный элемент массива: " + max);
    Console.WriteLine("Минимальный элемент массива: " + min);
    Console.WriteLine("Разница: " + (max - min));

}
printResult();