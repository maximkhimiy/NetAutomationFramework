using AcceptanceTesting.Common;
using OpenQA.Selenium;

namespace AcceptanceTesting.PageObjects
{
    public class GoogleSearchResultPage : BasePage
    {
        public IWebElement SearchButton { get { return FindElementByXPath("//button[@id='gbqfb']"); } }
        public IWebElement FirstLink { get { return FindElementByXPath("//h3[@class='r']/a"); } }

        public GoogleSearchResultPage(IWebDriver driver) : base(driver)
        {
        }

        public void clickSearchButton()
        {
            SearchButton.Click();
        }
           
    }
}