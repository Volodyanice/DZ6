Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());

int[,] array2D = new int[n, m];
FillArray2DRandomNumbers(array2D);

for ( int j = 0; j < array2D.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        avarage = avarage + array2D[i, j];
    }
    avarage = avarage/n;
    System.Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray2D(array2D);

void FillArray2DRandomNumbers(int [,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray2D(int [,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            System.Console.Write(array2D[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}