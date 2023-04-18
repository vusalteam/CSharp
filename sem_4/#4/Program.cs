/* 
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
 */

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int getCount()
{
    int count = 1;
    for (int i = 1; i <= number; i++)
    {

        count *= i;
    }
    return count;
}
Console.WriteLine("Произведение чисел: " + getCount());