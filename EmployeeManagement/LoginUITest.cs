using EmployeeManagement.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EmployeeManagement
{
    public class LoginUITest : AutomationWrapper
    {
        
        

       

        [Test]
        public void ValidateTitleTest()
        {
           
            string actualTitle = driver.Title;
            Assert.That(actualTitle, Is.EqualTo("OrangeHRM"));

        }
        [Test]
        public void ValidatePlaceholderTest()
        {
          
            string actualUsernamePlaceholder = driver.FindElement(By.Name("username")).GetAttribute("placeholder");
            Assert.That(actualUsernamePlaceholder, Is.EqualTo("Username"));
            
        }
    }
}