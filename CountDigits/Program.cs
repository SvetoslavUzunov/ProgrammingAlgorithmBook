int number = 4255;

int countDigits = 0;
while (number > 0)
{
    number /= 10;
    countDigits++;
}

Console.WriteLine(countDigits);