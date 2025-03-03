// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

double CalculateAverage(int[] numbers)
{
    int sum = 0;

    for (int k = 0; k < numbers.Length; k++)
    {
        sum += numbers[k];
    }

    return sum / numbers.Length;
}

int GetMaxValue(int[] numbers)
{
    int maxValue = numbers[0];

    foreach (int number in numbers)
    {
        if (number > maxValue) maxValue = number;
    }

    return maxValue;
}