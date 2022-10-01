/* Найти в массиве самую длинную последовательность, состоящую из
одинаковых элементов. Вывести на экран количество элементов самой
длиной последовательности, элемент самой последовательности и номер
элемента, который является ее началом. */

Console.Clear();
Console.WriteLine("Введите числа через пробел");
string input = Console.ReadLine()!;
int[] array = ParseToArray(input);

indexOfMax(array);
int indexMin = (indexOfMax(array) - (MaxOfRep(array) - 1));
int a = MaxOfRep(array);

if (a > 1)
{
    Console.WriteLine();
    Console.WriteLine($"Количество элементов самой длинной "
    + $"последовательности: {MaxOfRep(array)}");
    Console.WriteLine($"Элемент самой последовательности: "
    + $"{array[indexMin]}");
    Console.WriteLine($"Индекс первого элемента последовательности: "
    + $"{indexMin}");
}
else
Console.WriteLine("Повторяющихся элементов не найдено!");


int MaxOfRep (int[] array)
{
    int count = 1;
    int maxCount = 0;
    int maxPos = 0; 
    for (int i = 0; i < array.Length; i++)
    {   
        if (i < array.Length - 1)
        {
            if (array[i] != array[i + 1])
            {   
                if (maxPos > maxCount)
                    maxCount = maxPos;
                        
                maxPos = count;
                count = 1; 
            }

            else 
            {
                if (maxPos > maxCount)
                    maxCount = maxPos;
                       
                count = count + 1;
                maxPos = count;   
            }
        }

        else if (array[i] != array[i - 1])
            {   
                if (maxPos > maxCount)
                    maxCount = maxPos;
                        
                maxPos = count;
                count = 1; 
            }

            else 
            {
                if (maxPos > maxCount)
                    maxCount = maxPos;
                       
                count = count + 1;
                maxPos = count;
            }
    }
    return maxCount;
}

int indexOfMax (int[] array)
{
    int count = 1;
    int maxCount = 0;
    int maxPos = 0; 
    int indexOfMax = 0;
    for (int i = 0; i < array.Length; i++)
    {   
        if (i < array.Length - 1)
        {
            if (array[i] != array[i + 1])
            {   
                if (maxPos > maxCount)
                {
                    maxCount = maxPos;
                    indexOfMax = i;
                }
                        
                maxPos = count;
                count = 1; 
            }

            else 
            {
                if (maxPos > maxCount)
                {
                    maxCount = maxPos;
                    indexOfMax = i;  
                }
                       
                count = count + 1;
                maxPos = count; 
            }
        }

        else if (array[i] != array[i - 1])
            {   
                if (maxPos > maxCount)
                {
                    maxCount = maxPos;
                    indexOfMax = i;
                }
                        
                maxPos = count;
                count = 1; 
            }

            else 
            {
                if (maxPos > maxCount)
                {
                    maxCount = maxPos;
                    indexOfMax = i;
                }
                       
                count = count + 1;
                maxPos = count;
                    
            }
    }
    return indexOfMax;
}

int[] ParseToArray(string str)
{
    string[] stringArray = str.Split(" ");
    int[] result = new int[stringArray.Length];
 
    for (int i = 0; i < stringArray.Length; i++)
    {
        result[i] = int.Parse(stringArray[i]);
    }
 
    return result;
}

