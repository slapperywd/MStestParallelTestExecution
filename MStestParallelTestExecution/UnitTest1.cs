using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MStestParallelTestExecution
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void TestMethod1()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Navigate().GoToUrl("https://kb.epam.com/pages/viewpage.action?pageId=378549796&flashId=-1078927678");

        //}

        //[TestMethod]
        //public void TestMethod2()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Navigate().GoToUrl("https://kb.epam.com/pages/viewpage.action?pageId=378549796&flashId=-1078927678");

        //}

        [TestMethod]
        public void TestMethod1()
        {
            Thread.Sleep(3000);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Thread.Sleep(3000);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Thread.Sleep(3000);
        }
    }
}
