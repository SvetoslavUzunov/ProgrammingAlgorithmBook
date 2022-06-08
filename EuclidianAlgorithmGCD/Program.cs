int m = 50;
int n = 100;

while (m != 0)
{
    if (m < n)
    {
        int temp = m;
        m = n;
        n = temp;

        m %= n;
    }
}
Console.WriteLine($"{n}");