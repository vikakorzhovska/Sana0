using System.Text;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

Console.WriteLine("Введіть 5 оцінок за 100 бальною шкалою");
Console.WriteLine("Оцінка 1: ");
int one = int.Parse(Console.ReadLine());
Console.WriteLine("Оцінка 2: ");
int two = int.Parse(Console.ReadLine());
Console.WriteLine("Оцінка 3: ");
int three = int.Parse(Console.ReadLine());
Console.WriteLine("Оцінка 4: ");
int four = int.Parse(Console.ReadLine());
Console.WriteLine("Оцінка 5: ");
int five = int.Parse(Console.ReadLine());
double av = (one + two + three + four + five) / 5;
if (av >= 50)
{
    Console.WriteLine("Студент допущений");
}
else
{
    Console.WriteLine("Студент не допущений");
}