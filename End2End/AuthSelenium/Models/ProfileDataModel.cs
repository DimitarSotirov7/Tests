using OpenQA.Selenium;

namespace AuthenticationUI.Tests.Models
{
    public class ProfileDataModel
    {
        public IWebElement FirstName { get; set; }

        public IWebElement LastName { get; set; }

        public IWebElement Age { get; set; }

        public IWebElement Email { get; set; }
    }
}
