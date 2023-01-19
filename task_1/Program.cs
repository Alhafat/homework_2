// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

int count=0;
int result=0;

while (true)
{
    Console.Write("Введите трехзначное число: ");
    int number=int.Parse(Console.ReadLine()!);
    if ((number<100)||(number>999))
    {
        Console.WriteLine($"Неверно выполнено условие!!! Попробуйте еще раз, пожалуйста!!!");
        continue;
    }
    else
    {
        // //вариант 1
        // while (count<2)
        // {
        //     result=number/10%10;
        //     count++;
        // count++;  
        // break;
        // }
        // Console.WriteLine($"Второй цифрой введенного числа {number} является {result}");

        // //Вариант 2
        // result=number%100/10;
        // Console.WriteLine($"Второй цифрой введенного числа {number} является {result}");
        // break;

        // //Вариант 3
        Console.WriteLine($"Второй цифрой введенного числа {number} является {number%100/10}");
        break;
    }
}