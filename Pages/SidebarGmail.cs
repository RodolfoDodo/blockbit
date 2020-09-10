

using Coypu;

namespace Gmail.Pages
{
    public class SidebarGmail
    {
        private readonly BrowserSession _browser;

        public SidebarGmail(BrowserSession browser)
        {
            _browser = browser;
        }

        public string LoggedUser()
        {
            _browser.FindXPath("/html/body/div[7]/div[3]/div/div[1]/div[3]/header/div[2]/div[3]/div[1]/div[2]/div/a").Click();
            return _browser.FindXPath("/html/body/div[7]/div[3]/div/div[1]/div[3]/header/div[2]/div[4]/div[1]/div[2]/div[1]").Text;
        }

    }
}