System.Console.WriteLine("введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [5, 5];
FillArrayRandomNumbers(numbers);
PrintArray2D(numbers);
void PrintArray2D(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i ++)
    {
        for (int j = 0; j < array2D.GetLength(1); j ++)
        {
            System.Console.Write(array2D[i, j] + ", ");
        }

        System.Console.WriteLine();
    }
}
void FillArrayRandomNumbers(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = new Random().Next(-100, 100);
        }
    }
}
if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    System.Console.WriteLine("нету");
}
else
{
    System.Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n-1,m-1]}");
}