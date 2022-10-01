/*Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

Console.Clear();
Console.Write("Введите размер массива ");
int arrayLenght = int.Parse(Console.ReadLine()!);
int [] array = new int [arrayLenght];

FillArray(array);
PrintArray(array);
Console.WriteLine($" Сумма элементов, стоящих на нечетных позициях: "
+$"{FindNum(array)}");


void FillArray(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-10,10);
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
{   int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            summ = summ + array[i];
    }
    return summ;
}