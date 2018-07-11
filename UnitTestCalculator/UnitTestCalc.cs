using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorApplication;

namespace UnitTestCalculator
{
    [TestClass]
    public class UnitTestCalc
    {
        StringCalculator StringCalc;
        [TestInitialize]
        public void setup()
        {
            StringCalc = new StringCalculator();
        }
        
        [TestMethod]
        public void TestReturnZeroIfEmptyString()
        {

            string numbers = string.Empty;
            int result = StringCalc.Add(numbers);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestTheNumberIfSingleNumber()
        {
            string numbers = "1";
            int result = StringCalc.Add(numbers);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestAddWithMultipleNumbersInStringReturnsTheTotal()
        {
            string numbers = "1,2";
            int result = StringCalc.Add(numbers);
            Assert.AreEqual(3,result);
        }

        [TestMethod]
        public void ReturnSplitByNewLine()
        {

            string numbers = "1\n2,1";

            int result = StringCalc.Add(numbers);
            Assert.AreEqual(4, result);

            
        }

    }
}
