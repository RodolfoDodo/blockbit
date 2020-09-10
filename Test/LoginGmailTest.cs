using NUnit.Framework;
using Gmail.Pages;
using Gmail.Cammon;

namespace Gmail.Test
{
    public class LoginGmailTest : Basetest
    {
        private LoginGmailPage _login;

        private SidebarGmail _side;

        [SetUp]
        public void Start()
        {
            _login = new LoginGmailPage(Browser);
            _side = new SidebarGmail(Browser);

        }

        [Test]
        public void SuccessfullyLogin()
        {
            _login.Width("josebrenopires.josebrenopires@gmail.com", "dodo940808");
            Assert.AreEqual("José José Breno Pires", _side.LoggedUser());
        }
    }
}

