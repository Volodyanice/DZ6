int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int [size];
Random Rand = new Random();
for (int i = 1; i < size; i++)
{
    numbers[i] = Rand.Next(-999, 999);
    System.Console.Write(numbers[i] + ", ");
}
int kol(int[] numbers)
{
    int sum = 0;
    int i = 0;
    while (i < numbers.Length)
    {
        if (numbers[i] > 0)
        {
            sum = sum + 1;
        }
        i = i +1;
    }
    return sum;
}
System.Console.WriteLine($"количество чисел больше 0 = {kol(numbers)}");