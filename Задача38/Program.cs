/* Задайте массив вещественных чисел. Найдите разницу между максимальным
и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

Console.Clear();
Console.Write("Введите размер массива ");
int arrayLenght = int.Parse(Console.ReadLine()!);
double [] array = new double [arrayLenght];

FillArray(array);
PrintArray(array);
Console.WriteLine($" {NotSum(array)}");


void FillArray(double[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rand.NextDouble(), 3) + 
        rand.Next(-99, 100);
    }
}

void PrintArray(double[] array)
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

double NotSum(double[] array)
{   double min = array[0];
    double max = array[0];
    double sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        if (array[i] < min)
            min = array[i]; 
    }
    sum = max - (-min);
    return Math.Round(sum, 3);
}