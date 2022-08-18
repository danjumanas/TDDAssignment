using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TDDAssignment;

namespace TDDAssignmentTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //data row takes in multiple test inputs as strings which we convert then assign to variables
        [DataRow("100","20","5")]                       
        [DataRow("1000", "100", "10")]
        [DataRow("70", "7", "10")]
        public void SpeedTest(string distance, string time, string espectedResult)
        {
            double dist = double.Parse(distance);
            double t = double.Parse(time);
            double expRslt = double.Parse(espectedResult);
            var speed = new SpeedCalc();
            double result = speed.SpeedCalculator(dist, t);
            Assert.AreEqual(expRslt, result);                       // checks expected result against actual result
        }
    }
}
