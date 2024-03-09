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

static double GetMax(int[] numbers)
{
    int max = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max) max = numbers[i];
    }
    return max;
}



int[] numbers = { 1, 12, 45, 4 };
double average = GetAverage(numbers);
Console.WriteLine(average);
Console.WriteLine(GetMax(numbers));

