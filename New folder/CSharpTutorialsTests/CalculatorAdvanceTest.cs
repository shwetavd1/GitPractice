//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using NUnit.Framework;
//using NUnit;
//using CSharpTutorials;

//namespace CSharpTutorialsTests
//{

//    [TestFixture]
//    public class CalculatorAdvanceTest
//    {
//        private Calculator _calculator;

//        [SetUp]
//        public void SetUp()
//        {
//            _calculator = new Calculator();
//        }

//        [Test]
//        public void Calculator_AdditionOfPositiveNumbersReturnsCorrectSum_Test()
//        {
//            int number1 = 30;
//            int number2 = 5;
//            int expected_output = 35;

//            int result = _calculator.addition(number1, number2);

//            Assert.Equals(expected_output, result);

//        }

//        [TestCase(-1, -2, 3)]
//        [TestCase(-1, 2, 3)]
//        [TestCase(1, -2, 3)]
//        public void Calculator_AdditionOfSignedNumbersReturnsCorrectSum_Test(int first, int second, int expected_output)
//        {
//            int addition = _calculator.addition(first, second);
//            Assert.Equals(expected_output, addition);
//        }


//    }
//}
