﻿/* Задайте одномерный массив, заполненный
* случайными числами. Найдите сумму элементов,
* стоящих на нечётных позициях.*/
int []array = new int[10];
int length = array.Length;
int index = 0;
int sum = 0;

while (index < length)
{
    array[index] = new Random().Next(0, 10);
    Console.Write($"{array[index]}  ");
    index++;
}
System.Console.WriteLine();
for (int i = 0; i < length; i++)
{
    if (i % 2 != 0)
    {
        sum = sum + array[i];
    }
}
System.Console.WriteLine($"Сумма элементов на нечетных позициях равна {sum}");