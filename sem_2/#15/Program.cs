/* 
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
 */

Console.WriteLine("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
bool isWeekend = (day == 6 || day == 7);

if (isWeekend)
{
    Console.WriteLine("Да");

}
else
{
    Console.WriteLine("Нет");
}