Console.WriteLine("Введите b1, k1");
double b1 = Convert.ToDouble(Console.ReadLine());
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2, k2");
double b2 = Convert.ToDouble(Console.ReadLine());
double k2 = Convert.ToDouble(Console.ReadLine());
double x = -(b1-b2)/(k1-k2);
double y = k1*x + b1;
System.Console.WriteLine($"пересечение в точке: ({x};{y})");