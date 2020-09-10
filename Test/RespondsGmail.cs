using System;
using Gmail.Cammon;
using Gmail.Pages;
using NUnit.Framework;

namespace Gmail.Test
{
    public class RespondsGmailTest : Basetest
    {
        private LoginGmailPage _loginpage;

        private RespondsGmailPage _respondsgmailpage;

        [SetUp]
        public void Before()
        {
            _loginpage = new LoginGmailPage(Browser);
            _respondsgmailpage = new RespondsGmailPage(Browser);
            _loginpage.Width("josebrenopires.josebrenopires@gmail.com", "dodo940808");
        }

        [Test]
        public void Responder()
        {

            var outputPath = Environment.CurrentDirectory;
            var coverPath = outputPath + "\\Images\\"; 


            _respondsgmailpage.SelectEmail();

            var respostaMassa = new Models()
            {
                Resposta = "Rodolfo Teste",
                Cover = CoverPath() + "marvel.jpg"

            };

            _respondsgmailpage.AnswerEmail(respostaMassa);

            _respondsgmailpage.SubmitEmail();

        }
    }
}