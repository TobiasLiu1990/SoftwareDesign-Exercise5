namespace Fractions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction = new Fraction(1, 2);
            Fraction fraction2 = new Fraction(2, 3);

            Console.WriteLine("Multiply: " + fraction.Multiplication(fraction2));
            Console.WriteLine("Add: " + fraction.Addition(fraction2));
            Console.WriteLine("Subtract: " + fraction.Subtraction(fraction2));
            Console.WriteLine("Divide: " + fraction.Division(fraction2));


            Fraction reducedFraction = new Fraction(9, 21);
            reducedFraction = reducedFraction.Reduce(reducedFraction);

            Console.WriteLine("---Reduced fraction---: " + reducedFraction);
        }
    }
}