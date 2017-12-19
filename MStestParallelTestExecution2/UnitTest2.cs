using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MStestParallelTestExecution2
{
    [TestClass]
    public class UnitTest2
    {

        [TestMethod]
        public void TestMethod3()
        {
            Thread.Sleep(3000);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Thread.Sleep(3000);
        }


        [TestMethod]
        public void TestMethod5()
        {
            Thread.Sleep(3000);
        }
    }
}
