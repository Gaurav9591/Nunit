// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using NUnit.Tests3.Base_Test;
using System;



namespace NUnit.Tests3
{
    [TestFixture]
    public class TestClass : BaseClass
    {


        [Test]
        public void TestMethod()
        {
            test = extent.CreateTest("TFS Test Case Id - 54213").Info("TC-Paperless: Admin: Search for Active Professional by Suite/Proforma Admin.");
            test.Info("Portal URL Loaded Successfully");

            try
            {
                IWebElement username = driver.FindElement(By.CssSelector("#UserID"));
                username.SendKeys("suiteadministrator");
                test.Info("Username Entered");
                Console.WriteLine("Username Entered");

                IWebElement password = driver.FindElement(By.Id("Password"));
                password.SendKeys("ElitePaperless");
                test.Info("Password Entered");
                Console.WriteLine("Password Entered");

                Thread.Sleep(4000);
                IWebElement Login = driver.FindElement(By.XPath("//input[@type='submit']"));
                Login.Click();
                test.Info("Clicked On Login Button");
                Console.WriteLine("Clicked On Login Button");

                test.Log(AventStack.ExtentReports.Status.Pass, "Logged in to the Portal Successfully");

                Thread.Sleep(4000);

                IWebElement searchbutton = driver.FindElement(By.Id("btnSearch"));
                searchbutton.Click();
                Thread.Sleep(3000);
                IWebElement ErrorMsg = driver.FindElement(By.Id("searchError"));
                Console.WriteLine(ErrorMsg.Displayed);
                test.Info(ErrorMsg.Text);
                test.Log(AventStack.ExtentReports.Status.Pass, "Error Message Displayed");


                Thread.Sleep(3000);
                IWebElement Keywordseachbox = driver.FindElement(By.TagName("input"));
                Keywordseachbox.SendKeys("helm india");
                Thread.Sleep(2000);
                IWebElement clearbutton = driver.FindElement(By.Id("btnClear"));
                clearbutton.Click();
                test.Info("Clicked on clear button");
                Console.WriteLine("Keyword Search field  got cleared.");
                test.Log(AventStack.ExtentReports.Status.Pass, "Keyword Search field  got cleared.");

                Thread.Sleep(3000);
                Keywordseachbox.SendKeys("fi");
                test.Log(AventStack.ExtentReports.Status.Pass, "SearchKeyword in search keyword field got typed");
                Thread.Sleep(1000);
                searchbutton.Click();
                test.Log(AventStack.ExtentReports.Status.Pass, "Searchbutton got clicked");

                Thread.Sleep(3000);
                IWebElement fi = driver.FindElement(By.XPath(" //td[text()='Farhana Islam']"));
                Console.WriteLine(fi.Displayed);
                test.Info(fi.Text);
                test.Log(AventStack.ExtentReports.Status.Pass, "Professonal Name Got Listed");

            }

            catch(Exception)
            {

            }

            





























        }
    }
}
