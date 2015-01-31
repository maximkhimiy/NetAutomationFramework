using AcceptanceTesting.Common;
using AcceptanceTesting.PageObjects;
using NUnit.Framework;
using System.Threading;

namespace AcceptanceTesting.TestCases
{
    public class GoogleSearchResultTest : BaseTest
    {
        private GoogleStartPage googlePage;
        private GoogleSearchResultPage googleSearchResultPage;

        public GoogleSearchResultTest(string browserName) : base(browserName)
        {
        }

        [Test]
        public void Google_Should_Find_Selenium_Site()
        {
            Step("Ввод запроса 'смс автоматизация'",
                () => googleSearchResultPage = googlePage.EnterSearchText("selenium"));

            Step("Нажатие на кнопку Search",
                () => googleSearchResultPage.clickSearchButton());

            Step("Первая ссылка должна содержать адрес sms-automation.ru",
                () =>
                {
                    var href = googleSearchResultPage.FirstLink.GetAttribute("href");
                    Assert.AreEqual(href, "http://www.seleniumhq.org/");
                });
        }

        protected override void Setup()
        {
            base.Setup();
            Step("Открыть google.com", () => googlePage = new GoogleStartPage(Driver));
        }
    }
}