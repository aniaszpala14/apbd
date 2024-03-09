// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Zmiana 3!");

static double GetAverage(int[] numbers)
{
    double res = 0.0;
    for (int i = 0; i < numbers.Length; i++)
    {
        res += numbers[i];
    }

    return res / numbers.Length;
}

int[] numbers = { 1, 2, 3, 4 };
double average = GetAverage(numbers);
Console.WriteLine(average);
