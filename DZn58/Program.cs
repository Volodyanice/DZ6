int[,] matrix1 = new int[2, 2];
int[,] matrix2 = new int[2, 2];
int[,] resultMatrix = new int[2, 2];
RandomNumberMatrix1(matrix1);
PrintMatrix1(matrix1);
RandomNumberMatrix2(matrix2);
PrintMatrix2(matrix2);
ResultMatrix(resultMatrix);
PrintMatrix1(resultMatrix);


void RandomNumberMatrix1(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void RandomNumberMatrix2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix1(int[,] array)
{
    for (int i =0; i < array.GetLength(0); i++)
    {
        for ( int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void PrintMatrix2(int[,] array)
{
    for (int i =0; i < array.GetLength(0); i++)
    {
        for ( int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void ResultMatrix(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matrix1.GetLength(1); k++)
      {
        sum += matrix1[i,k] * matrix2[k,j];
      }
      array[i,j] = sum;
    }
  }
}