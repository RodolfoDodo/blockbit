
using System;
using Coypu;
using Coypu.Drivers.Selenium;
using NUnit.Framework;

namespace Gmail.Cammon
{
    public class Basetest
    {
        protected BrowserSession Browser;

        [SetUp]
        public void Setup()
        {
            var configs = new SessionConfiguration
            {
                AppHost = "https://mail.google.com/mail/u/0/#inbox",
                Driver = typeof(SeleniumWebDriver),
                Browser = Coypu.Drivers.Browser.Chrome,
                Timeout = TimeSpan.FromSeconds(10)
            };

            Browser = new BrowserSession(configs);
            Browser.MaximiseWindow();

        }

        public string CoverPath()
        {
            var outputPath = Environment.CurrentDirectory;
            return outputPath + "\\images\\";

        }

        [TearDown]
        public void Finish()
        {

        }


    }
}