using EmployeeManagement.Base;
using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class LoginTest : AutomationWrapper
    {
        [Test]
        public void ValidLoginTest()
        {
            driver.FindElement(By.Name("username")).SendKeys("Admin");
            driver.FindElement(By.Name("password")).SendKeys("admin123");
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            string homePageLink = driver.Url;
            Assert.That(homePageLink, Is.EqualTo("https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index%22))"));
               
        }
        public static object[] InvalidLoginData()
        {
            string[] DataSet1 = new string[2];
            DataSet1[0] = "john";
            DataSet1[1] = "john123";

            string[] DataSet2 = new string[2];
            DataSet2[0] = "peter";
            DataSet2[1] = "peter123";

            string[] DataSet3 = new string[2];
            DataSet3[0] = "saul";
            DataSet3[1] = "saul123";

            object[] AllDataSet = new object[3];
            AllDataSet[0] = DataSet1;
            AllDataSet[1] = DataSet2;
            AllDataSet[2] = DataSet3;

            return AllDataSet;
        }

        [Test,TestCaseSource(nameof(InvalidLoginData))]

       // [TestCase("ab","123","Invalid credential")]
        //[TestCase("peter","@123","Invalid credential")]
        //[TestCase("pet", "@12", "Invalid credential")]
        public void InValidLoginTest(string username,string Password,string expectedError)
        {
            driver.FindElement(By.Name("username")).SendKeys(username);
            driver.FindElement(By.Name("password")).SendKeys(Password);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            string actualError =driver.FindElement(By.XPath("//div[@class='oxd-alert-content oxd-alert-content--error']")).Text;
            Assert.That(actualError.Contains("expectedError"),"Assertion On Error Message");




        }
    }
}
