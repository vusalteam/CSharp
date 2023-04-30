/* 
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
 */
int rows = 4;
int columns = 5;
int [,] arr = new int[rows,columns];
for (int i = 0; i < arr.GetLength(0); i++) {
    Console.Write("#{0} [ ",i);
    for (int j = 0; j < arr.GetLength(1); j++) {
            arr[i,j] = new Random().Next(0,10);
       Console.Write("{0} ",arr[i,j]);
    }
    Console.WriteLine("]");
}
int sum = 0;
for (int i = 0; i < arr.GetLength(0) && i < arr.GetLength(1);i++) {
    sum += arr[i,i];
}
Console.WriteLine("Сумма элементов главной диагонали: {0}",sum);