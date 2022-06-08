int[,] matrix = new int[5, 5];

int bottomPartOfMatrix = 1;
int topPartOfMatrix = 20;

for (int col = 0; col < matrix.GetLength(1); col++)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        if (col == row)
        {
            matrix[row, col] = 0;
        }
        else if (row > col)
        {
            matrix[row, col] = bottomPartOfMatrix++;
        }
        else
        {
            matrix[row, col] = topPartOfMatrix--;
        }
    }
}

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        Console.Write($"{matrix[row, col]} ");
    }
    Console.WriteLine();
}