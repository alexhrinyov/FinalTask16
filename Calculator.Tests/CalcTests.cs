using FinalTask16;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class CalcTests
    {
        [Test]
        public void AdditionMustReturn3()
        {
            Functions fn = new Functions();
            Assert.AreEqual(3, fn.Addition(2, 1));           
        }
        [Test]
        public void SubstractionMustReturn1()
        {
            Functions fn = new Functions();
            Assert.AreEqual(1, fn.Subtraction(2, 1));
        }
        [Test]
        public void DivisionMustReturn6()
        {
            Functions fn = new Functions();
            Assert.AreEqual(6, fn.Division(36, 6));
        }
        [Test]
        public void MultMustReturn320()
        {
            Functions fn = new Functions();
            Assert.AreEqual(320, fn.Miltiplication(16, 20));
        }
    }
}