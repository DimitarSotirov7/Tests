using AuthenticationUI.Tests.Components;
using NUnit.Framework;
using System.Threading;

namespace AuthenticationUI.Tests.Tests
{
    public class LoginTests : BaseTests
    {
        [Test]
        public void Login()
        {
            var nav = new Nav(this.driver);
            nav.OpenLogin();

            new Login(this.driver).Submit();
            Thread.Sleep(20);
            //Assert
            var token = nav.GetToken();
            Assert.IsTrue(token != null);
        }

        [Test]
        public void Logout()
        {
            var nav = new Nav(this.driver);
            nav.OpenLogin();

            new Login(this.driver).Submit();
            Thread.Sleep(20);

            nav.Logout();
            Thread.Sleep(20);
            //Assert
            var token = nav.GetToken();
            Assert.IsTrue(token == null);
        }
    }
}
