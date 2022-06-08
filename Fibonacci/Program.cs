namespace Fibonaci;

public class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        //Console.WriteLine(FibonaciAlgorithm(n));

        int firstNum = 0, secondNum = 1;
        while (n-- > 0)
        {
            secondNum = firstNum + secondNum;
            firstNum = secondNum - firstNum;

            //Console.Write(secondNum + " ");
        }

        Drob(10, 15);
    }

    private static int FibonaciAlgorithm(int n)
    {
        if (n < 2)
        {
            return 1;
        }

        return FibonaciAlgorithm(n - 1) + FibonaciAlgorithm(n - 2);
    }

    private static void Drob(int number1, int number2)
    {
        int num1 = DrobAlgorithm(number1);
        int num2 = DrobAlgorithm(number2);

        Console.WriteLine();
        Console.WriteLine($"{num1}/{num2}");
    }

    private static int DrobAlgorithm(int number)
    {
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                return i;
            }
        }

        return number;
    }
}