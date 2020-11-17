using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicMath;

namespace BasicMathTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTest()
        {
            //Arrange
            double num1 = 5;
            double num2 = 10;
            var expected = 15;

            //act
            BasicMathsClass ab = new BasicMathsClass();
            var actual = ab.Add(num1, num2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SubstractTest()
        {
            //Arrange
            double num1 = 20;
            double num2 = 5;
            var expected = 15;

            //act
            BasicMathsClass ag = new BasicMathsClass();
            var actual = ag.Substract(num1, num2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DivideTest()
        {
            //Arrange
            double num1 = 20;
            double num2 = 10;
            var expected = 2;

            //act
            BasicMathsClass et = new BasicMathsClass();
            var actual = et.Divide(num1, num2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MultiplyTest()
        {
            //Arrange
            double num1 = 20;
            double num2 = 5;
            var expected = 100;

            //act
            BasicMathsClass vd = new BasicMathsClass();
            var actual = vd.Multiply(num1, num2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
