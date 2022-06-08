namespace Factrec;

public class Factrec
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int step = 1;
        List<int> numbers = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            numbers.Add(step *= 10);
        }

        for (int i = 0; i < numbers.Count; i++)
        {
            Console.Write($"{numbers[i]} ");
        }
        for (int i = numbers.Count - 1; i >= 0; i--)
        {
            Console.Write($"{numbers[i]} ");
        }
    }
}