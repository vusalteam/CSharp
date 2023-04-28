/* 
Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12

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