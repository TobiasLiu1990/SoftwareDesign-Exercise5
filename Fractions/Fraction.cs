using System;
using System.Data.Common;

public class Fraction
{
    public int Numerator { get; set; } = 0;
    public int Denominator { get; set; } = 1;

    public Fraction(int numerator, int denominator)
    {
        Numerator = numerator;

        if (Denominator > 0) {
            Denominator = denominator;
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
        if (this.ToDouble() > input.ToDouble()) {
            return true;
        }
        return false;
    }

    public bool LesserThan(Fraction input)
    {
        if (this.ToDouble() < input.ToDouble()) {
            return true;
        }
        return false;
    }

    public bool Equals(Fraction input)
    {
        if (this.ToDouble() == input.ToDouble()) {
            return true;
        } else {
            return false;
        }
    }

    public double ToDouble()
    {
        return (double)Numerator / (double)Denominator;
    }

    public static Fraction operator -(Fraction Fraction1, Fraction Fraction2)
    {
        return Fraction1.Subtraction(Fraction2);
    }

    public static Fraction operator +(Fraction Fraction1, Fraction Fraction2)
    {
        return Fraction1.Addition(Fraction2);
    }

    public static Fraction operator *(Fraction Fraction1, Fraction Fraction2)
    {
        return Fraction1.Multiplication(Fraction2);
    }

    public static Fraction operator /(Fraction Fraction1, Fraction Fraction2)
    {
        return Fraction1.Division(Fraction2);
    }

    public static bool operator ==(Fraction Fraction1, Fraction Fraction2)
    {
        return Fraction1.Equals(Fraction2);
    }

    public static bool operator !=(Fraction Fraction1, Fraction Fraction2)
    {
        return !Fraction1.Equals(Fraction2);
    }

    public static bool operator <(Fraction Fraction1, Fraction Fraction2)
    {
        return Fraction1.LesserThan(Fraction2);
    }

    public static bool operator >(Fraction Fraction1, Fraction Fraction2)
    {
        return Fraction1.GreaterThan(Fraction2);
    }

    public static bool operator <=(Fraction Fraction1, Fraction Fraction2)
    {
        return (Fraction1.Equals(Fraction2) || Fraction1.LesserThan(Fraction2));
    }

    public static bool operator >=(Fraction Fraction1, Fraction Fraction2)
    {
        return (Fraction1.Equals(Fraction2) || Fraction1.GreaterThan(Fraction2));
    }

    public override bool Equals(object? obj)
    {
        if (obj is Fraction fraction) {
            return Equals(fraction);
        } else {
            return false;
        }
    }


    public override string ToString()
    {
        return Numerator + "/" + Denominator + "\n";
    }



}
