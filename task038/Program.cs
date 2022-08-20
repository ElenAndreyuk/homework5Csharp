/*Задайте массив вещественных чисел.
* Найдите разницу между максимальным и
* минимальным элементов массива.*/
float []array = {3, 7, 22, 2, 78};
int length = array.Length;
float difference = 0;

float max = array[0];
float min = array[0];
for (int i = 1; i < length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
difference = max - min;
System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива {difference}");
