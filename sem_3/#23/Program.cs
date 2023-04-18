/* 
Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int[] table = new int[number];

for (int i = 0; i < number; i++)
{
    table[i] = (i + 1) * (i + 1) * (i + 1);
}

for (int i = 0; i < number; i++)
{
    Console.Write(table[i] );
    if (i != number - 1){
        Console.Write(", ");
    }
}