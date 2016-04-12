using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwedishFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwedishFrameworkTests;

namespace SwedishFramework.Tests
{
    [TestClass()]
    public class SwedishBooleanTests
    {
        [TestMethod()]
        public void GetAnswerTest_Sant()
        {
            var answer = new SwedishBoolean(SwedishBoolean.Status.Sant).GetAnswer();

            Assert.IsTrue(answer);
        }

        [TestMethod()]
        public void GetAnswerTest_Falskt()
        {
            var answer = new SwedishBoolean(SwedishBoolean.Status.Falskt).GetAnswer();

            Assert.IsFalse(answer);
        }

        [TestMethod()]
        public void GetAnswerTest_Ibland()
        {
            var result = false;
            for(int i = 0; i < 100000; i++)
            {
                if (new SwedishBoolean(SwedishBoolean.Status.Ibland).GetAnswer())
                    result = true;
            }

            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void GetAnswerTest_Kanske()
        {
            if (new SwedishBoolean(SwedishBoolean.Status.Kanske).GetAnswer())
                throw new KanskeActuallyMeansNoException();

            Assert.IsFalse(false);
        }
    }
}