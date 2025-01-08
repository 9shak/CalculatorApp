using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorApp;
using System;

namespace CalculatorAppTest
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestAdd()
        {
            double number1 = 10;
            double number2 = 10;
            double expected = 20;

            double actual = Program.Add(number1, number2);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestSubtract()
        {
           
            double number1 = 15;
            double number2 = 12;
            double expected = 3;

         
            double actual = Program.Subtract(number1, number2);

           
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultiply()
        {
           
            double number1 = 25;
            double number2 = 25;
            double expected = 625;

           
            double actual = Program.Multiply(number1, number2);

            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDivide()
        {
           
            double number1 = 8;
            double number2 = 2;
            double expected = 4;

           
            double actual = Program.Divide(number1, number2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivideByZero()
        {
            
            double number1 = 6;
            double number2 = 0;

            
            Program.Divide(number1, number2);

            
        }
    }
    }

