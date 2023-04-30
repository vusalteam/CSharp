/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
Console.WriteLine("Введите количество строк массива");
string? inputM = Console.ReadLine();
int m = string.IsNullOrEmpty(inputM) ? 0 : int.Parse(inputM);

Console.WriteLine("Введите количество столбцов массива");
string? inputN = Console.ReadLine();
int n = string.IsNullOrEmpty(inputN) ? 0 : int.Parse(inputN);

double[,] arr = new double[m, n];
for (int i = 0; i < arr.GetLength(0); i++){
    for (int j = 0; j < arr.GetLength(1); j++){
        arr[i,j] = Math.Round(new Random().NextDouble()* 20 - 10, 2);
    }
}
Console.WriteLine("Полученный массив");
for (int i = 0; i < arr.GetLength(0); i++){
    for (int j = 0; j < arr.GetLength(1); j++)    {
        Console.Write(arr[i,j] + " ");
    }
    Console.WriteLine();
}