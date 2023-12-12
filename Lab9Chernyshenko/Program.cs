try
{
Drob drob = new Drob();
double Procent = drob.Procent();
Console.WriteLine("Значение дроби в процентах:" + Procent);
int Summa = drob.Sum();
Console.WriteLine($"Сумма цифр знаменателя:" + Summa);
Console.ReadLine();
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
class Drob
{
    private int numerator;
    private int denominator;
    public Drob()
    {
        Console.WriteLine("Введите числитель");
        int numerator=int.Parse(Console.ReadLine());
        Console.WriteLine("Введите знаменатель");
        int denominator=int.Parse(Console.ReadLine());
    }
    public double Procent()
    {
        return (double)numerator / denominator * 100;
    }
    public int Sum()
    {
        int sum = 0;
        int tempDenominator = denominator;

        while (tempDenominator != 0)
        {
            sum += tempDenominator % 10;
            tempDenominator /= 10;
        }

        return sum;
    }
}


