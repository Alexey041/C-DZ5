Console.Clear();

int[] array = CreateArray();

(int, int, int) result = FindMaxSequence(array);
Console.WriteLine($"Element: {result.Item1}");
Console.WriteLine($"Count: {result.Item2}");
Console.WriteLine($"Start: {result.Item3}");


int[] CreateArray()
{
    return new int[] { 1, 2, 2, 4, 4, 4, 4, 3, 3 ,3, 4};
}


(int, int, int) FindMaxSequence(int[] array)
{    
    int currentSequenceElement = array[0];
    int currentSequnceCounter = 0;
    int currentSequenceStart = 0;
    
    int maxSequenceElement = array[0];
    int maxSequnceCounter = 0;
    int maxSequenceStart = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != currentSequenceElement)
        {
            if (currentSequnceCounter > maxSequnceCounter)
            {
                maxSequenceElement = currentSequenceElement;
                maxSequnceCounter = currentSequnceCounter;
                maxSequenceStart = currentSequenceStart;
            }

            currentSequenceElement = array[i];
            currentSequnceCounter = 0;
            currentSequenceStart = i;
        }
        currentSequnceCounter++;
    }

    return (maxSequenceElement, maxSequnceCounter, maxSequenceStart);
}