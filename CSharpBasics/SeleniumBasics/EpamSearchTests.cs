using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SeleniumBasics
{
    public class EpamSearchTests
    {
        private IWebDriver _driver { get; set; }
        private const string _epamUrl = "https://www.epam.com/";

        [SetUp]
        public void SetupBrowser()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize(); 
            _driver.Navigate().GoToUrl(_epamUrl);
        }

        [Test]
        public void CheckAbilityToSearchFromEpamSiteHeader()
        {
            var textToSearch = "Automation";
            var expectedNumberOfArticles = 10;
            //var searchIconLocator = By.XPath("//span[contains(@class,'dark-iconheader-search__search-icon')]");
            //var searchPanelLocator = By.XPath("//form[@action]");
            //var searchInputLocator = By.Id("new_form_search");
            //var searchButtonLocator = By.XPath(".//*[@class='bth-text-layer']");
            //var articleLocator = By.XPath("//article[@class='search-results__item']");

            var searchIcon = _driver.FindElement(By.XPath("//span[contains(@class,'dark-iconheader-search__search-icon')]"));
            searchIcon.Click();
            
            //Thread.Sleep(3000);

            var searchPanel = _driver.FindElement(By.XPath("//form[@action]"));

            var searchInput = _driver.FindElement(By.Id("new_form_search"));
            searchInput.SendKeys(textToSearch);

            var searchButton = searchPanel.FindElement(By.XPath(".//*[@class='bth-text-layer']"));
            searchButton.Click();

            var articles = _driver.FindElements(By.XPath("//article[@class='search-results__item']"));
            Assert.That(articles, Has.Count.EqualTo(expectedNumberOfArticles), "Invalid number of articles present!");
        }
        
        [TearDown]
        public void TearDown()
        {
            _driver.Close();
            _driver.Quit();
        }
    }
}
