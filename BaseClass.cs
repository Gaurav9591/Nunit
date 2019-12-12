using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Threading;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;


namespace NUnit.Tests3.Base_Test
{

    public class BaseClass
    {

        public IWebDriver driver;

        public ExtentReports extent = null;

        public ExtentTest test = null;



        [OneTimeSetUp]

        public void Report()
        {

            extent = new ExtentReports();

            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\gakumar\source\repos\NUnit.Tests3\ExtentReports\PaperlessPortalTest.html");
            extent.AttachReporter(htmlReporter);




        }


        [SetUp]

        public void browser()
        {

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            // TODO: Add your test code here
            driver.Url = "http://localhost:8008/ProLawPortal/#/Login";
            Console.WriteLine("Logged in to paperless portal");
          

            Thread.Sleep(5000);




        }




        [OneTimeTearDown]
        public void close()
        {
           
            driver.Quit();

            extent.Flush();
        }




    }
}
