// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Ведите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99)
{
    int thirdDigit = ThirdDigit(number);
    Console.WriteLine($"Третья цифра числа - {thirdDigit}");
}
else Console.WriteLine("Третьей цифры нет");

int ThirdDigit(int number)
{
    int result = number / 100 % 10;
    return result;
}


