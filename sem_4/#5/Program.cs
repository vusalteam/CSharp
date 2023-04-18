/* 
Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
 */

int[] numArr = new int[8];

for(int i=0;i<numArr.Length;i++){
    numArr[i] = new Random().Next(0,2);
} 

    Console.WriteLine(String.Join(", ", numArr));

