namespace Recursion;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(Sum(10));
    }

    public static int Sum(int num)
    {
        if (num == 0)
        {
            return 0;
        }

        return num += Sum(num - 1);
    }
}