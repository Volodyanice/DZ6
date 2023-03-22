void FillArray2D(double [,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i ++)
    {
        for (int j = 0; j < array2D.GetLength(1); j ++)
        {
            array2D[i, j] = i + j;
        }
    }
}
void FillArrayRandomNumbers(double[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}
void PrintArray2D(double [,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i ++)
    {
        for (int j = 0; j < array2D.GetLength(1); j ++)
        {
            System.Console.Write(array2D[i, j] + " ");
        }

        System.Console.WriteLine();
    }
}

int m = 3;
int n = 4;

double[,] array2D = new double[m, n];
FillArray2D(array2D);
FillArrayRandomNumbers(array2D);
PrintArray2D(array2D);
