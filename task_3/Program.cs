// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

while (true)
{
    Console.Write("Введите порядковый номер дня недели: ");
    int x=int.Parse(Console.ReadLine());

    if ((x<=0)||(x>7))
    {
        Console.WriteLine("Такого дня недели не существует");
        continue;
    }
    else
    {
        if (x==1) 
        {
            Console.WriteLine("Понедельник");
        }
        if (x==2) 
        {
            Console.WriteLine("Вторник");
        }
        if (x==3) 
        {
            Console.WriteLine("Среда");
        }
        if (x==4) 
        {
            Console.WriteLine("Четверг");
        }
        if (x==5) 
        {
            Console.WriteLine("Пятница");
        }
        if (x==6) 
        {
            Console.WriteLine("Суббота");
        }
        if (x==7) 
        {
            Console.WriteLine("Воскресенье");
        }
        if ((x>=1)&&(x<=5)) 
        {
            Console.WriteLine("Рабочий день");
            break;
        }
        else 
        {
            Console.WriteLine("Выходной день");
            break;
        }
    }
}