using NUnit.Framework;
using net_calculator_tester;

namespace UnitTestCalcolatrice
{
    //Classe contenente tutti i test
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //testa funzione somma
        [Test]
        [TestCase(2, 4, 6)]
        [TestCase(-2, 4, 2)]
        [TestCase(2, -4, -2)]
        public void Add(float x, float y, float result)
        {
            Assert.That(Calcolatrice.Add(x, y), Is.EqualTo(result));
        }
        //testa funzione sottrazione
        [Test]
        [TestCase(2, 4, -2)]
        [TestCase(-2, 4, -6)]
        [TestCase(2, -4, 6)]
        public void Subtract(float x, float y, float result)
        {
            Assert.That(Calcolatrice.Subtract(x, y), Is.EqualTo(result));
        }
        //testa funzione dividi
        [Test]
        [TestCase(4, 2, 2)]
        [TestCase(-4, 2, -2)]
        [TestCase(4, -2, -2)]
        public void Divide(float x, float y, float result)
        {
            Assert.That(Calcolatrice.Divide(x, y), Is.EqualTo(result));
        }
        //testa funzione nel caso numeri passati siano 0
        [Test]
        [TestCase(10, 0)]
        [TestCase(0, 0)]
        public void DivideByZero(float n, float d)
        {
            Assert.Throws<ArgumentException>(() => Calcolatrice.Divide(n, d));
        }
        //testa funzione moltiplicazione
        [Test]
        [TestCase(4, 2, 8)]
        [TestCase(-4, 2, -8)]
        [TestCase(4, -2, -8)]
        public void Multiply(float x, float y, float result)
        {
            Assert.That(Calcolatrice.Multiply(x, y), Is.EqualTo(result));
        }
    }
}