/*Задайте массив заполненный случайными положительными
* трёхзначными числами. Напишите программу, которая покажет 
* количество чётных чисел в массиве.*/
int []array = new int[7];
int length = array.Length;
int index = 0;
int count = 0;

while (index < length)
{
    array[index] = new Random().Next(100, 1000);
    Console.Write($"{array[index]}  ");
    index++;
}
Console.WriteLine();
for (int i = 0; i < length; i++)
{
    if (array[i] % 2 == 0)
    {
        count++;
    }
}
switch (count)
{
    case 1 :
    {
       Console.WriteLine($"В данном массиве {count} четное число");
       break;
    }
    case 2:
    case 3:
    case 4:
    {
       Console.WriteLine($"В данном массиве {count} четных числа");
       break;
    }
    default:
    {
       Console.WriteLine($"В данном массиве {count} четных чисел");
       break;
    }
}
