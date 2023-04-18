﻿/* 
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
 */

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100){
    int[] digits = number.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
    int thirdDigit = digits[2];
    Console.WriteLine("Третья цифра: " + thirdDigit);
}else{
    Console.WriteLine("Третьей цифры нет");
}


