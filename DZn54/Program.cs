Console.WriteLine("n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("m");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
RandomNumberArray(matrix);
PrintArray(matrix);
SortFromMoreNumber(matrix);
System.Console.WriteLine();
PrintArray(matrix);

void RandomNumberArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void SortFromMoreNumber(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int max = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    max = array[i, k];
                }
            }
        }
    }
}