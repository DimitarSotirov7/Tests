using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AuthenticationUI.Tests.Tests
{
    public abstract class BaseTests
    {
        private const string URL = "http://localhost:4200/";
        private IWebDriver webDriver = new ChromeDriver();

        [SetUp]
        public void Setup()
        {
            this.webDriver.Navigate().GoToUrl(URL);
        }

        public IWebDriver driver => this.webDriver;

        [TearDown]
        public void TearDown() => this.driver.Quit();
    }
}
