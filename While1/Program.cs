using System.Text;

internal class Program
{
     private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
        Console.Write("Введіть натуральне число n: ");
        int n = int.Parse(Console.ReadLine());
        double a = CalculationA(n);
        Console.WriteLine($"a = {a}");
        double b = CalculationB(n);
        Console.WriteLine($"b = {b}");
        int c = CalculationC(n);
        Console.WriteLine($"c = {c}");
    }
    static double CalculationA(int n) 
    {
        double sum = 0;
        for (int i = 0; i <= n; i++)
        {
            sum = Math.Pow(-1, i) / (2 * i + 1.0);
        }
        return sum;
    }

    static double CalculationB(int n)
    {
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum = 1 + 1.0 / Math.Pow(i, 2);
        }
        return sum;
    }

    static int CalculationC(int n)
    {
        int factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}
