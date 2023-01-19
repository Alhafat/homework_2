// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

Console.Write("Введите любое трехзначное число число: ");
int number=int.Parse(Console.ReadLine()!);

int count=0;
int result=0;

while (count<2)
{
    result=number/10%10;
    count++;
count++;  
break;
}

Console.WriteLine($"Второй цифрой введенного числа {number} является {result}");

// Console.WriteLine($"Второй цифрой введенного числа {number} является {number%100/10}");