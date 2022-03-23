using OpenQA.Selenium;

namespace AuthenticationUI.Tests.Components
{
    public class Login
    {
        private readonly IWebDriver driver;
        private const string Username = "dsotirov";
        private const string Password = "dsotirov123";

        public Login(IWebDriver webDriver)
        {
            this.driver = webDriver;
        }

        public void Submit(string username = Username, string password = Password)
        {
            this.driver.FindElement(By.Name("username")).SendKeys(Username);
            this.driver.FindElement(By.Name("password")).SendKeys(Password);

            this.driver.FindElement(By.XPath("//button[@type='submit']")).Submit();
        }
    }
}
