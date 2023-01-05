using EmployeeManagement.Base;
using EmployeeManagement.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class EmployeeTest : AutomationWrapper
    {
        [Test, TestCaseSource(typeof(DataSource), nameof(DataSource.ValidEmployeeTest))]

        public void AddValidEmployee(String Username, string Password, string Firstname, string Middlename, string Lastname, string Employeename)
        {

            driver.FindElement(By.Name("username")).SendKeys(Username);
            driver.FindElement(By.Name("password")).SendKeys(Password);
            driver.FindElement(By.XPath("//button[@type = 'submit']")).Click();
            driver.FindElement(By.XPath("//span[text()='PIM']")).Click();
            driver.FindElement(By.XPath("//a[text()='Add Employee']")).Click();
            driver.FindElement(By.Name("firstName")).SendKeys(Firstname);
            driver.FindElement(By.Name("middleName")).SendKeys(Middlename);
            driver.FindElement(By.Name("lastName")).SendKeys(Lastname);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            string EmployeeName1 = driver.FindElement(By.XPath("//h6[@class='oxd-text oxd-text--h6 --strong']")).Text;
            EmployeeName1.ToCharArray();
            Assert.That(Employeename.Contains(EmployeeName1), "Assert on error message");



        }
    }
}
