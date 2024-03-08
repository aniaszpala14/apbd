// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Zmiana 3!");

static double GetAverage(int[] numbers)
{
    double result = 0.0;
    for (int i = 0; i < numbers.Length; i++)
    {
        result += numbers[i];
    }

    return result / numbers.Length;
}

