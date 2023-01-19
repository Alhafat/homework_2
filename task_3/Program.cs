// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите порядковый номер дня недели: ");
int x=int.Parse(Console.ReadLine());

while (true)
{
    if ((x<0)||(x>7));
    {
        Console.Write("Такого дня недели не существует");
        continue;
    }
    // else
    // {
    //     if (x==1) Console.Write("Понедельник");

    //     if (x==2) Console.Write("Вторник");

    //     if (x==3) Console.Write("Среда");

    //     if (x==4) Console.Write("Четверг");

    //     if (x==5) Console.Write("Пятница");

    //     if (x==6) Console.Write("Суббота");

    //     if (x==7) Console.Write("Воскресенье");
    // }
}