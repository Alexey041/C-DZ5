/* Задайте массив заполненный случайными положительными трёхзначными
числами. Напишите программу, которая покажет количество чётных чисел
в массиве.
[345, 897, 568, 234] -> 2 */

Console.Clear();
Console.Write("Введите размер массива ");
int arrayLenght = int.Parse(Console.ReadLine()!);
int [] array = new int [arrayLenght];

FillArray(array);
PrintArray(array);
Console.WriteLine($" Количество четных: {FindNum(array)}");


void FillArray(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(100,1000);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i == array.Length - 1)
        Console.Write("]");
        else
        Console.Write(", ");
    }
}

int FindNum(int[] array)
{   int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count = count + 1;
    }
    return count;
}