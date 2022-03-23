using AuthenticationUI.Tests.Components;
using AuthenticationUI.Tests.Models;
using NUnit.Framework;
using System.Threading;

namespace AuthenticationUI.Tests.Tests
{
    public class ProfileTests : BaseTests
    {
        [Test]
        public void CheckData()
        {
            var nav = new Nav(this.driver);
            nav.OpenLogin();

            new Login(this.driver).Submit();
            Thread.Sleep(20);

            nav.OpenProfile();
            Thread.Sleep(20);

            ProfileDataModel data = new Profile(this.driver).GetData();
            //Assert
            Assert.That(data.FirstName != null);
            Assert.That(data.LastName != null);
            Assert.That(data.Age != null);
            Assert.That(data.Email != null);
        }

        [Test]
        public void ChangeFirstName()
        {
            var nav = new Nav(this.driver);
            nav.OpenLogin();

            new Login(this.driver).Submit();
            Thread.Sleep(20);

            nav.OpenProfile();
            Thread.Sleep(20);

            var profile = new Profile(this.driver);
            var firstName = profile.GetData().FirstName;
            var firstNameText = firstName.Text;

            firstName.Clear();
            firstName.SendKeys(firstNameText + 1);

            profile.Submit();
            firstName = profile.GetData().FirstName;

            //Assert
            Assert.That(firstName.Text == firstNameText + 1);
        }
    }
}
