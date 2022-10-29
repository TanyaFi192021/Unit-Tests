using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathLibrary;
using System;

namespace MathLibraryTests
{
    [TestClass]
    public class CalcTests
    {
        [TestMethod]
        public void Add_5and3_expected8()
        {
            //arrange
            int a = 5, b = 3;
            int expected = 8;
            //act
            Calc calc = new Calc();
            int actual = calc.Add(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Max_10and20_expected20()
        {
            //arrange
            double a = 10, b = 20;
            double expected = 20;
            //act
            Calc calc = new Calc();
            double actual = calc.Max(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Proiz_4and5_expected20()
        {
            //arrange
            double a = 4, b = 5;
            double expected = 20;
            //act
            Calc calc = new Calc();
            double actual = calc.Proiz(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Del_10and5_expected2()
        {
            //arrange
            double a = 10, b = 5;
            double expected = 2;
            //act
            Calc calc = new Calc();
            double actual = calc.Del(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Razn_30and20_expected10()
        {
            //arrange
            double a = 30, b = 20;
            double expected = 10;
            //act
            Calc calc = new Calc();
            double actual = calc.Razn(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Min_25and15_expected15()
        {
            //arrange
            double a = 25, b = 15;
            double expected = 15;
            //act
            Calc calc = new Calc();
            double actual = calc.Min(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Ostatok_10and4_expected2()
        {
            //arrange
            double a = 10, b = 4;
            double expected = 2;
            //act
            Calc calc = new Calc();
            double actual = calc.Ostatok(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sqrt_16_expected4()
        {
            //arrange
            double a = 16;
            double expected = 4;
            //act
            Calc calc = new Calc();
            double actual = calc.Sqrt(a);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Pow_3and3_expected27()
        {
            //arrange
            double a = 3, b = 3;
            double expected = 27;
            //act
            Calc calc = new Calc();
            double actual = calc.Pow(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Abs_10_expected10()
        {
            //arrange
            double a = 10;
            double expected = 10;
            //act
            Calc calc = new Calc();
            double actual = calc.Abs(a);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Acos_1_expected0()
        {
            //arrange
            double a = 1;
            double expected = 0;
            //act
            Calc calc = new Calc();
            double actual = calc.Acos(a);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Log_100and10_expected2()
        {
            //arrange
            double a = 100, b = 10;
            double expected = 2;
            //act
            Calc calc = new Calc();
            double actual = calc.Log(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Log10_10_expected1()
        {
            //arrange
            double a = 10;
            double expected = 1;
            //act
            Calc calc = new Calc();
            double actual = calc.Log10(a);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
