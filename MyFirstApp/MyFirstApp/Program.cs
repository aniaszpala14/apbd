// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Zmiana 3!");

static double GetAverage(int[] numbers)
{
    double result2 = 0.0;
    for (int i = 0; i < numbers.Length; i++)
    {
        result2 += numbers[i];
    }

    return result2 / numbers.Length;
}

int[] numbers = { 1, 2, 3, 4 };
double average = GetAverage(numbers);
Console.WriteLine(average);
