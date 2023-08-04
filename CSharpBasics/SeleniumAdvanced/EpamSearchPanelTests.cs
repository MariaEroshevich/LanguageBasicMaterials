using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace SeleniumAdvanced
{
    public class EpamSearchPanelTests
    {
        private IWebDriver _driver { get; set; }
        private WebDriverWait _waiter { get; set; }
        private const string _epamUrl = "https://www.epam.com/";
        
        [SetUp, Order(1)]
        public void SetupBrowser()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            //_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }

        [SetUp, Order(2)]
        public void SetupWaiter()
        {
            var _explicitTimeout = TimeSpan.FromSeconds(5);
            var _explicitPollingInterval = TimeSpan.FromSeconds(1);

            _waiter = new WebDriverWait(_driver, _explicitTimeout)
            {
                PollingInterval = _explicitPollingInterval
            };
        }

        [Test]
        public void CheckAbilityToOpenSearchPanelByClickingSearchOnHeader()
        {
            var searchButtonLocator = By.XPath("//button[contains(@class, 'header-search')]");
            var searchPanelLocator = By.XPath("//*[contains(@class, 'header-search__panel opened')]");

            _driver.Navigate().GoToUrl(_epamUrl);

            var searchButton = _driver.FindElement(searchButtonLocator);
            searchButton.Click();

            //var searchPanel = _waiter.Until(d => d.FindElement(searchPanelLocator));
            //var searchPanel = _driver.FindElement(searchPanelLocator);

            _waiter.IgnoreExceptionTypes(typeof(StaleElementReferenceException), typeof(NoSuchElementException));
            var searchPanelDisplayedState = _waiter.Until(condition =>
            {
                try
                {
                    var elementToDisplayed = _driver.FindElement(searchPanelLocator);
                    return elementToDisplayed.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });

            Assert.That(searchPanelDisplayedState, Is.True, "Search panel is not present after clicking search on header!");
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Close();
            _driver.Quit();
        }
    }
}