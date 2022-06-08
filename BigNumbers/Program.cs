//Намиране на съвършенни числа

int n = int.Parse(Console.ReadLine());

for (int num = 1; num <= n; num++)
{
    int sum = 0;
    for (int j = 1; j < num; j++)
    {
        if (num % j == 0)
        {
            sum += j;
        }
    }

    if (num == sum)
    {
        Console.WriteLine(num);
    }
}