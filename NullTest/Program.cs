using System.Diagnostics;

List<int> list1 = new List<int>();

for (int i = 0; i < 10000; i++)
{
    list1.Add(i);
}

Stopwatch timer = new Stopwatch();
timer.Start();
Parallel.ForEach(list1, (number) =>
{
    number *= number;
});
timer.Stop();
Console.WriteLine($"Parallel: {timer.ElapsedMilliseconds}");