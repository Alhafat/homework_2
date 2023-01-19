﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

while (true)
{
    Console.Write("Введите порядковый номер дня недели: ");
    int x=int.Parse(Console.ReadLine());

    if ((x<0)^(x>7))
    {
        Console.Write("Такого дня недели не существует");
        continue;
    }
}