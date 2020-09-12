using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberWords;
using System.Text.RegularExpressions;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void WordForZero()
        {
            Assert.AreEqual("zero", Class1.FormatNumber(0));
        }

        [TestMethod]
        public void TeensContainTeenSuffix()
        {
            for(int i=13;i<20;i++)
            {
            StringAssert.EndsWith(Class1.FormatNumber(i), "teen", "Teen number ending is wrong");
            }
        }

        [TestMethod]
        public void TensContainsTySuffix()
        {
            for(int i=20; i<=90; i+=10)
            {
                StringAssert.EndsWith(Class1.FormatNumber(i), "ty", "Tens number ending is wrong");
            }
        }

        [TestMethod]
        public void NumberWordContainsHyphenWhenTensIsNotZero()
        {
            StringAssert.Contains(Class1.FormatNumber(92), "-");
        }
        [TestMethod]
        public void NumberWordDoesntContainHyphenWhenTensIsZero()
        {
            Assert.IsFalse(Class1.FormatNumber(102).Contains("-"));
            Assert.IsFalse(Class1.FormatNumber(2).Contains("-"));
        }

        [TestMethod]
        public void NumberWordContainsAndWhenHundredsNotZero()
        {
            StringAssert.Contains(Class1.FormatNumber(102), "and");
        }

        [TestMethod]
        public void NumberWordContainsHundredWhenHundredsNotZero()
        {
            for(int i=100;i<=900;i+=100)
            { 
            StringAssert.Contains(Class1.FormatNumber(i), "hundred");
            }
        }
        [TestMethod]
        public void NumberWordContainsThousandWhenThousandsNotZero()
        {
            for (int i = 1000; i <= 10000; i += 1000)
            {
                StringAssert.Contains(Class1.FormatNumber(i), "thousand");
            }
        }
    }
}
