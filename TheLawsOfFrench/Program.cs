int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

int currentSmallest = int.MaxValue;
int total = 0;

foreach (int arrayItem in array)
{
    if (arrayItem < currentSmallest)
        currentSmallest = arrayItem;

    total += arrayItem;
}

float average = (float)total / array.Length;

Console.WriteLine($"smallest: {currentSmallest}");
Console.WriteLine($"average: {average}");