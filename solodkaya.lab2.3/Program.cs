
Console.Write("Введите n:");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите x:");
double x = double.Parse(Console.ReadLine());
switch (n)
{
    case 1:
        {
            double a = 1.5;
            double b = 5.7; double z = Math.Log(Math.Abs(Math.Tan(b * x)));
            double y = 0; if (x < a) y = a + z * Math.Pow(Math.Cos(a), 2) * Math.Pow(b * x, 3);
            else if (a <= x && (x <= b)) y = a + Math.Pow(Math.Sin(a), 2) * Math.Pow(b, 2) + Math.Log(z * x); else if (x > b) y = Math.Pow(Math.Sqrt(0.3 * b + Math.Sqrt(Math.Abs(a - Math.Pow(z, 2) - Math.Cos(x)))), 3);
            Console.WriteLine($"y={y:F2}");
        }
        break;
    case 2:
        {
            double a = 3.7;
            double b = 8.4; double z = Math.Log(Math.Abs(Math.Tan(b * x)));
            double y = 0; if (x < a) y = a + z * Math.Pow(Math.Cos(a), 2) * Math.Pow(b * x, 3);
            else if (a <= x && (x <= b)) y = a + Math.Pow(Math.Sin(a), 2) * Math.Pow(b, 2) + Math.Log(z * x); else if (x > b) y = Math.Pow(Math.Sqrt(0.3 * b + Math.Sqrt(Math.Abs(a - Math.Pow(z, 2) - Math.Cos(x)))), 3);
            Console.WriteLine($"y={y:F2}");
        }
        break;
    case 3:
        {
            double a = 4.4;
            double b = 5.6; double z = Math.Log(Math.Abs(Math.Tan(b * x)));
            double y = 0; if (x < a) y = a + z * Math.Pow(Math.Cos(a), 2) * Math.Pow(b * x, 3);
            else if (a <= x && (x <= b)) y = a + Math.Pow(Math.Sin(a), 2) * Math.Pow(b, 2) + Math.Log(z * x); else if (x > b) y = Math.Pow(Math.Sqrt(0.3 * b + Math.Sqrt(Math.Abs(a - Math.Pow(z, 2) - Math.Cos(x)))), 3);
            Console.WriteLine($"y={y:F2}");
        }
        break;
}