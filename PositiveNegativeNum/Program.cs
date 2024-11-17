namespace PositiveNegativeNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            double number = double.Parse(Console.ReadLine());

            Num num = new Num();
            num.IsPositive(number);
        }
    }
}