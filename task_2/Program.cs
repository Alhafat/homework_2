// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. (Цифры считать справа налево).

// 645 -> 6

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Clear();

Console.Write("Введите любое число: ");
int number=int.Parse(Console.ReadLine()!);

if (number<100)
{
    Console.WriteLine($"У введенного числа {number} искомая цифра отсутвсует");
}
else
{
    result=number/100%10;
    Console.WriteLine(result);
}