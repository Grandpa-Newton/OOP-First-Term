using Lab2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ComplexNumberUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSum1()
        {
            ComplexNumber firstNumber = new ComplexNumber(2, 3);
            ComplexNumber secondNumber = new ComplexNumber(3, 4);

            ComplexNumber sumNumber = firstNumber + secondNumber;

            ComplexNumber expected = new ComplexNumber(5, 7);

            Assert.AreEqual(expected.real, sumNumber.real);
            Assert.AreEqual(expected.imagine, sumNumber.imagine);
        }
        [TestMethod]
        public void TestSum2()
        {
            ComplexNumber firstNumber = new ComplexNumber(-2, 3);
            ComplexNumber secondNumber = new ComplexNumber(3, 1);

            ComplexNumber sumNumber = firstNumber + secondNumber;

            ComplexNumber expected = new ComplexNumber(1, 4);

            Assert.AreEqual(expected.real, sumNumber.real);
            Assert.AreEqual(expected.imagine, sumNumber.imagine);
        }
        [TestMethod]
        public void TestSum3()
        {
            ComplexNumber firstNumber = new ComplexNumber(-9, 16);
            ComplexNumber secondNumber = new ComplexNumber(9, -3);

            ComplexNumber sumNumber = firstNumber + secondNumber;

            ComplexNumber expected = new ComplexNumber(0, 13);

            Assert.AreEqual(expected.real, sumNumber.real);
            Assert.AreEqual(expected.imagine, sumNumber.imagine);
        }
        [TestMethod]
        public void TestSum4()
        {
            ComplexNumber firstNumber = new ComplexNumber(4, 0);
            ComplexNumber secondNumber = new ComplexNumber(0, 4);

            ComplexNumber sumNumber = firstNumber + secondNumber;

            ComplexNumber expected = new ComplexNumber(4, 4);

            Assert.AreEqual(expected.real, sumNumber.real);
            Assert.AreEqual(expected.imagine, sumNumber.imagine);
        }
        [TestMethod]
        public void TestSum5()
        {
            ComplexNumber firstNumber = new ComplexNumber(4, 9);
            ComplexNumber secondNumber = new ComplexNumber(15, 16);

            ComplexNumber sumNumber = firstNumber + secondNumber;

            ComplexNumber expected = new ComplexNumber(19, 25);

            Assert.AreEqual(expected.real, sumNumber.real);
            Assert.AreEqual(expected.imagine, sumNumber.imagine);
        }
        [TestMethod]
        public void TestSum6()
        {
            ComplexNumber firstNumber = new ComplexNumber(23, 42);
            ComplexNumber secondNumber = new ComplexNumber(-3, -98);

            ComplexNumber sumNumber = firstNumber + secondNumber;

            ComplexNumber expected = new ComplexNumber(20, -56);

            Assert.AreEqual(expected.real, sumNumber.real);
            Assert.AreEqual(expected.imagine, sumNumber.imagine);
        }
        [TestMethod]
        public void TestSum7()
        {
            ComplexNumber firstNumber = new ComplexNumber(2.5, 3.7);
            ComplexNumber secondNumber = new ComplexNumber(-1.5, 0.3);

            ComplexNumber sumNumber = firstNumber + secondNumber;

            ComplexNumber expected = new ComplexNumber(1, 4);

            Assert.AreEqual(expected.real, sumNumber.real);
            Assert.AreEqual(expected.imagine, sumNumber.imagine);
        }
        [TestMethod]
        public void TestSum8()
        {
            ComplexNumber firstNumber = new ComplexNumber(-0.05, 3);
            ComplexNumber secondNumber = new ComplexNumber(2.55, 4);

            ComplexNumber sumNumber = firstNumber + secondNumber;

            ComplexNumber expected = new ComplexNumber(2.5, 7);

            Assert.AreEqual(expected.real, sumNumber.real);
            Assert.AreEqual(expected.imagine, sumNumber.imagine);
        }
        [TestMethod]
        public void TestMult1() //
        {
            ComplexNumber firstNumber = new ComplexNumber(2, 3);
            ComplexNumber secondNumber = new ComplexNumber(3, 4);

            ComplexNumber sumNumber = firstNumber * secondNumber;

            ComplexNumber expected = new ComplexNumber(-6, 17);

            Assert.AreEqual(expected.real, sumNumber.real);
            Assert.AreEqual(expected.imagine, sumNumber.imagine);
        }
        [TestMethod]
        public void TestMult2() //
        {
            ComplexNumber firstNumber = new ComplexNumber(4, 9);
            ComplexNumber secondNumber = new ComplexNumber(7, 6);

            ComplexNumber sumNumber = firstNumber * secondNumber;

            ComplexNumber expected = new ComplexNumber(-26, 87);

            Assert.AreEqual(expected.real, sumNumber.real);
            Assert.AreEqual(expected.imagine, sumNumber.imagine);
        }
        [TestMethod]
        public void TestMult3() //
        {
            ComplexNumber firstNumber = new ComplexNumber(-2, 4);
            ComplexNumber secondNumber = new ComplexNumber(3, -1);

            ComplexNumber sumNumber = firstNumber * secondNumber;

            ComplexNumber expected = new ComplexNumber(-2, 14);

            Assert.AreEqual(expected.real, sumNumber.real);
            Assert.AreEqual(expected.imagine, sumNumber.imagine);
        }
        [TestMethod]
        public void TestMult4() //
        {
            ComplexNumber firstNumber = new ComplexNumber(-2, -3);
            ComplexNumber secondNumber = new ComplexNumber(-3, -4);

            ComplexNumber sumNumber = firstNumber * secondNumber;

            ComplexNumber expected = new ComplexNumber(-6, 17);

            Assert.AreEqual(expected.real, sumNumber.real);
            Assert.AreEqual(expected.imagine, sumNumber.imagine);
        }
        [TestMethod]
        public void TestMult5() //
        {
            ComplexNumber firstNumber = new ComplexNumber(2.5, 4);
            ComplexNumber secondNumber = new ComplexNumber(2, 4);

            ComplexNumber sumNumber = firstNumber * secondNumber;

            ComplexNumber expected = new ComplexNumber(-11, 18);

            Assert.AreEqual(expected.real, sumNumber.real);
            Assert.AreEqual(expected.imagine, sumNumber.imagine);
        }
        [TestMethod]
        public void TestMult6() //
        {
            ComplexNumber firstNumber = new ComplexNumber(-1, 1);
            ComplexNumber secondNumber = new ComplexNumber(1, 1);

            ComplexNumber sumNumber = firstNumber * secondNumber;

            ComplexNumber expected = new ComplexNumber(-2, 0);

            Assert.AreEqual(expected.real, sumNumber.real);
            Assert.AreEqual(expected.imagine, sumNumber.imagine);
        }
        [TestMethod]
        public void TestMult7() //
        {
            ComplexNumber firstNumber = new ComplexNumber(2.5, -2);
            ComplexNumber secondNumber = new ComplexNumber(4, -8);

            ComplexNumber sumNumber = firstNumber * secondNumber;

            ComplexNumber expected = new ComplexNumber(-6, -28);

            Assert.AreEqual(expected.real, sumNumber.real);
            Assert.AreEqual(expected.imagine, sumNumber.imagine);
        }
        [TestMethod]
        public void TestMult8() //
        {
            ComplexNumber firstNumber = new ComplexNumber(4, 8);
            ComplexNumber secondNumber = new ComplexNumber(15, 16);

            ComplexNumber sumNumber = firstNumber * secondNumber;

            ComplexNumber expected = new ComplexNumber(-68, 184);

            Assert.AreEqual(expected.real, sumNumber.real);
            Assert.AreEqual(expected.imagine, sumNumber.imagine);
        }

 
    }
}
