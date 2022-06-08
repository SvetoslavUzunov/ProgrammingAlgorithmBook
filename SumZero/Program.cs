namespace SumZero;

public class Program
{
    private static int[] numbers;
    private static int n;
    private static int targetSum = 0;

    public static void Main(string[] args)
    {
        n = int.Parse(Console.ReadLine());
        numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = i + 1;
        }

        Variate(0);
    }

    private static void Variate(int i)
    {
        if (i >= n)
        {
            Calculate();
            return;
        }

        numbers[i] = Math.Abs(numbers[i]);
        Variate(i + 1);

        numbers[i] = -Math.Abs(numbers[i]);
        Variate(i + 1);
    }

    private static void Calculate()
    {
        int totalSum = 0;
        for (int i = 0; i < n; i++)
        {
            totalSum += numbers[i];
        }

        if (totalSum == targetSum)
        {
            for (int i = 0; i < n; i++)
            {
                if (numbers[i] > 0)
                {
                    Console.Write($"+{+numbers[i]} ");
                }
                else
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
            Console.WriteLine($"= {targetSum}");
        }
    }
}