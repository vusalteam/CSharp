/* 
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int getNumSum(){
    int sum = 0;
    int temp = number;
    while (temp > 0){
        sum += temp % 10;
        temp /= 10;
    }
    return sum;
}

Console.WriteLine("Сумма цифр в числе: " + getNumSum());