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

            Fraction fraction3 = new Fraction(2, 3);
            Fraction fraction4 = new Fraction(2, 3);

            Console.WriteLine("Equal: " + fraction2.Equals(fraction3));

            Fraction fraction5 = new Fraction(10, 10);
            Fraction fraction6 = new Fraction(1, 10);

            Console.WriteLine("Is bigger: " + fraction5.GreaterThan(fraction6));

            Fraction fraction7 = new Fraction(1, 100);
            Fraction fraction8 = new Fraction(1, 1);

            Console.WriteLine("Is lesser: " + fraction7.LesserThan(fraction8));
        }
    }
}