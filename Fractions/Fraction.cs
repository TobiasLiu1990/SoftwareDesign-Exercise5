using System;

public class Fraction
{
    public int Numerator { get; set; } = 0;
    public int Denominator { get; set; } = 1;
    public double decimalFraction { get; set; } = 0;

    public Fraction(int numerator, int denominator)
    {
        Numerator = numerator;

        if (Denominator > 0) {
            Denominator = denominator;
            decimalFraction = (double)Numerator / (double)Denominator;
        }
        else {
            throw new ArgumentOutOfRangeException();
        }
    }

    public Fraction Multiplication(Fraction input)
    {
        int numeratorResult = Numerator * input.Numerator;
        int denominatorResult = Denominator * input.Denominator;

        return new Fraction(numeratorResult, denominatorResult);
    }

    public Fraction Addition(Fraction input)
    {
        int finalResult;
        int commonDenominator = Denominator;

        if (Denominator == input.Denominator) {
            finalResult = Numerator + input.Numerator;
        } 
        else {
            commonDenominator = Denominator * input.Denominator;
            int resultNumeratorOne = Numerator * input.Denominator;
            int resultNumeratorTwo = input.Numerator * Denominator;

            finalResult = resultNumeratorOne + resultNumeratorTwo;
        }
        return new Fraction(finalResult, commonDenominator);
    }

    public Fraction Subtraction(Fraction input)
    {
        int finalResult;
        int commonDenominator = Denominator;

        if (Denominator == input.Denominator) {
            finalResult = Numerator - input.Numerator;
        }
        else {
            commonDenominator = Denominator * input.Denominator;
            int resultNumeratorOne = Numerator * input.Denominator;
            int resultNumeratorTwo = input.Numerator * Denominator;

            finalResult = resultNumeratorOne - resultNumeratorTwo;
        }
        return new Fraction(finalResult, commonDenominator);
    }

    public Fraction Division(Fraction input)
    {
        int inputNewNumerator = Numerator * input.Denominator;
        int inputNewDenominator = Denominator * input.Numerator;

        return Reduce(new Fraction(inputNewNumerator, inputNewDenominator));
    }

    public Fraction Reduce(Fraction input)
    {
        int biggestNumber = Math.Min(input.Numerator, input.Denominator);

        while (biggestNumber > 1) {
            if (input.Numerator % biggestNumber == 0 && input.Denominator % biggestNumber == 0) {
                input.Numerator /= biggestNumber;
                input.Denominator /= biggestNumber;
                biggestNumber = Math.Min(input.Numerator, input.Denominator);
            }
            else {
                biggestNumber--;
            }
        }
        return new Fraction(input.Numerator, input.Denominator);
    }

    public bool GreaterThan(Fraction input)
    {
        double secondFraction = ToDouble(input);

        if (decimalFraction > secondFraction) {
            return true;
        }
        return false;
    }

    public bool LesserThan(Fraction input)
    {
        double inputFraction = ToDouble(input);

        if (decimalFraction < inputFraction) {
            return true;
        }
        return false;
    }

    public bool Equals(Fraction input)
    {
        double inputFraction = ToDouble(input);

        if (decimalFraction == inputFraction) {
            return true;
        } else {
            return false;
        }
    }

    public double ToDouble(Fraction input)
    {
        return (double)input.Numerator / (double)input.Denominator;
    }

    public override string ToString()
    {
        return "Numerator: " + Numerator + "\n" + "Denominator: " + Denominator + "\n";
    }



}
