using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit;
using CSharpTutorials;

namespace CSharpTutorialsTests
{

    [TestFixture]
    public class CalculatorAdvanceTest
    {
        private Calculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new Calculator();
        }

        //when the numbers and sum is positive
        [Test]
        public void AdditionOfPositiveNumbersReturnsCorrectSum_Test()
        {
            int number1 = 30;
            int number2 = 5;
            int expected_output = 35;

            int result = _calculator.addition(number1, number2);

            Assert.That(expected_output, Is.EqualTo(result));

        }

        //multiple test cases for addition method
        [TestCase(-1, -2, -3)]
        [TestCase(-1, 2, 1)]
        [TestCase(1, -2, -1)]
        public void AdditionOfSignedNumbers_ReturnsCorrectSum(int first, int second, int expected_output)
        {
            int addition = _calculator.addition(first, second);

            Assert.That(expected_output, Is.EqualTo(addition));
        }

        /* subtraction
         * 1. numbers are positive
         * 2. second number is greater than first - negative result
         * 3. both numbers are negative
         *     - first max, second min 
         *     - first min, second max
         * 4. first negative, second positive
         * 5. first positive, second negative
        */
        [Test]
        public void SubtractionOfPositiveNumbers_ReturnsCorrectSum_Test()
        {
            int number1 = 30;
            int number2 = 5;
            int expected_output = 25;
            int subtraction = _calculator.subtraction(number1, number2);
            Assert.That(expected_output, Is.EqualTo(subtraction));
        }

        [TestCase(5, 30, -25)]
        [TestCase(-5, -30, 25)]
        [TestCase(-30, -5, -25)]
        [TestCase(-30, 5, -35)]
        [TestCase(30, -5, 35)]
        public void SubtractionOfSignedIntegers_ReturnsCorrectDifference_Test(int first, int second, int expected_output)
        {
            int subtraction = _calculator.subtraction(first, second);
            Assert.That(expected_output, Is.EqualTo(subtraction));
        }


        /* multiplication
         * 1. both numbers are positive
         * 2. both numbers are negative
         * 3. numbers are of different signs
         * 4. either one is zero
        */

        [Test]
        public void MultiplicationOfPositiveNumbers_ReturnsCorrectMultiplication_Test()
        {
            int number1 = 30;
            int number2 = 5;
            int expected_output = 150;
            int multiplication = _calculator.multiplication(number1, number2);
            Assert.That(expected_output, Is.EqualTo(multiplication));
        }

        [TestCase(-30, -5, 150)]
        [TestCase(-30, 5, -150)]
        [TestCase(5, -30, -150)]
        public void MultiplicationOfSignedIntegers_ReturnsCorrectMultiplication(int first, int second, int expected_output)
        {
            int multiplication = _calculator.multiplication(first, second);
            Assert.That(expected_output, Is.EqualTo(multiplication));
        }

        /* Division
         * 1. both are positive
         * 2. both are negative
         * 3. either is of different sign
         * 4. divisor is greater than devident 
         * 5. divide by zero
         * 6. devide to zero
         */

        [Test]
        public void DividionOfPositiveNumbers_ReturnsCorrectQuotient_Test()
        {
            int number1 = 30;
            int number2 = 5;
            int expected_output = 6;
            int quotient = _calculator.divide(number1, number2);
            Assert.That(expected_output, Is.EqualTo(quotient));
        }


        [TestCase(-30, -5, 6)]
        [TestCase(-30, 5, -6)]
        [TestCase(30, -5, -6)]
        public void DivisionOfSignedNumbers_ReturnsCorrectQuotient(
            int dividend, int divisor, int expected)
        {
            int result = _calculator.divide(dividend, divisor);
            Assert.That(result, Is.EqualTo(expected));
        }


        [Test]
        public void Division_WhenDivisorIsZero_ThrowsDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(
                () => _calculator.divide(10, 0));
        }

    }
}
