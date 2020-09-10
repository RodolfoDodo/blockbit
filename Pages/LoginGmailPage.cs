using Coypu;

namespace Gmail.Pages
{
    public class LoginGmailPage
    {
        private readonly BrowserSession _browser;

        public LoginGmailPage(BrowserSession browser)
        {
            _browser = browser;
        }

        public void Load()
        {
            _browser.Visit("/");
        }

        public void Width(string email, string password)
        {
            this.Load();
            _browser.FillIn("identifierId").With(email);
            _browser.FindId("identifierNext").Click();
            _browser.FillIn("password").With(password);
            _browser.ClickButton("Próxima");
        }

        public void SelectEmail()
        {
            _browser.FindXPath("//td[4]/div[2]/span/span").Click();
        }

        public void AnswerEmail()
        {
            _browser.FindXPath("/html/body/div[7]/div[3]/div/div[2]/div[1]/div[2]/div/div/div/div/div[2]/div/div[1]/div/div[2]/div/table/tr/td[1]/div[2]/div[2]/div/div[3]/div/div/div/div/div/div[1]/div[2]/div[1]/table/tbody/tr[1]/td[4]/div[1]").Click();

        }

    }

}