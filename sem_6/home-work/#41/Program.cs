/* 
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Write("Введите числа через пробел: ");
string? input = Console.ReadLine();
string[]? numbers = input?.Split(" ", StringSplitOptions.RemoveEmptyEntries); 
int count = 0;

if (numbers != null) {
    foreach (string number in numbers) {
        if (int.TryParse(number, out int num)) { 
            if (num > 0) {
                count++;
            }
        } else {
            Console.WriteLine($"Неверный формат числа: `{number}`"); 
        }
    }
}
Console.WriteLine($"Количество чисел больше 0: {count}");
