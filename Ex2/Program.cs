Console.WriteLine("Enter k1");
double k1 = Double.Parse(Console.ReadLine());
Console.WriteLine("Enter b1");
double b1 = Double.Parse(Console.ReadLine());
Console.WriteLine("Enter k2");
double k2 = Double.Parse(Console.ReadLine());
Console.WriteLine("Enter b2");
double b2 = Double.Parse(Console.ReadLine());
double x, y; 
 
// Нахождение точки пересечения осуществляется с помощью системы уравнений, из нее в явном виде выразить нужно х и у

x = (b2 - b1) / (k1  - k2);
y = k1 * x + b1;
 
Console.WriteLine($"Cross in: ({x};{y})");