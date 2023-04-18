/* 
Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

string numberStr = number.ToString();
string reversedNumberStr = new string(numberStr.Reverse().ToArray());

if (numberStr == reversedNumberStr)
{
    Console.WriteLine("Палиндром");
}
else
{
    Console.WriteLine("Не палиндром");
}