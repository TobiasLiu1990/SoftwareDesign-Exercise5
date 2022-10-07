namespace FractionTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestFractionMethods()
        {
            Fraction f1 = new(1, 2);
            Fraction f2 = new(1, 2);

            Fraction actualAdd = f1.Addition(f2);
            Fraction actualSubtract = f1.Subtraction(f2);
            Fraction actualMultiply = f1.Multiplication(f2);
            Fraction actualDivide = f1.Division(f2);


            Assert.That(new Fraction(2,2), Is.EqualTo(actualAdd));
            Assert.That(new Fraction(0,2), Is.EqualTo(actualSubtract));
            Assert.That(new Fraction(1, 4), Is.EqualTo(actualMultiply));
            Assert.That(new Fraction(2, 2), Is.EqualTo(actualDivide));
        }

        [TestCase]
        public void TestDifferentParameters()
        {

        }
    }
}