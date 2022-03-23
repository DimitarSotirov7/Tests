using AuthenticationUI.Tests.Models;
using OpenQA.Selenium;
using System.Threading;

namespace AuthenticationUI.Tests.Components
{
    public class Profile
    {
        private readonly IWebDriver driver;

        public Profile(IWebDriver webDriver)
        {
            this.driver = webDriver;
        }

        public ProfileDataModel GetData() => new ProfileDataModel()
        {
            FirstName = this.driver.FindElement(By.XPath("//input[@name='firstName']")),
            LastName = this.driver.FindElement(By.XPath("//input[@name='lastName']")),
            Age = this.driver.FindElement(By.XPath("//input[@name='age']")),
            Email = this.driver.FindElement(By.Id("email"))
        };

        public void Submit()
        {
            this.driver.FindElement(By.XPath("//button[@type='submit']")).Submit();
            Thread.Sleep(50);
        }
    }
}
