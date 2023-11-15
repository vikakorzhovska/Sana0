using System.Text;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

Console.WriteLine("Введіть a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть b: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть c: ");
int c = int.Parse(Console.ReadLine());
double D = Math.Pow(b, 2) - 4 * a * c;
if (D > 0)
{
    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
    double x2 = (-b - Math.Sqrt(D)) / (2 * a);
    Console.WriteLine("x1 = {0}", x1);
    Console.WriteLine("x2 = {0}", x2);
}
else if (D == 0)
{
    double x = -b / (2 * a);
    Console.WriteLine("x = {0}", x);
}
else
{
    Console.WriteLine("Коренів немає");
}
