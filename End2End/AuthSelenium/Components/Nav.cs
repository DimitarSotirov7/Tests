using OpenQA.Selenium;
using System.Threading;

namespace AuthenticationUI.Tests.Components
{
    public class Nav
    {
        private readonly IWebDriver driver;
        private const string AuthCookieName = "NgNet.authorization.token";

        public Nav(IWebDriver webDriver)
        {
            this.driver = webDriver;
        }

        public void OpenLogin()
        {
            this.driver.FindElement(By.LinkText("Login")).Click();
        }

        public void OpenProfile()
        {
            this.driver.FindElement(By.LinkText("Profile")).Click();
        }

        public string GetToken()
        {
            return this.driver.Manage().Cookies.GetCookieNamed(AuthCookieName)?.Value;
        }

        public void Logout()
        {
            this.driver.FindElement(By.LinkText("Logout")).Click();
            Thread.Sleep(5);
            this.driver.FindElement(By.XPath("//button[@id='confirm']")).Click();
        }
    }
}
