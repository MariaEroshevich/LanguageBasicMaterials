using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace SeleniumBasics
{
    public class EpamNavigationTests
    {
        private IWebDriver driver { get; set; }
        private const string epamUrl = "https://www.epam.com/";

        [SetUp()]
        public void SetupBrowser()
        {
            //var options = new ChromeOptions();
            //options.BinaryLocation = "/Applications/Google Chrome.app/Contents/MacOS/Google Chrome";
            driver = new ChromeDriver();//(options);

            driver.Manage().Window.Maximize();
        }

        [Test]
        public void CheckNavigationToMainEpamPage()
        {
            driver.Navigate().GoToUrl(epamUrl);

            driver.FindElement(By.ClassName("cta-button-ui cta-button-ui-23 header__control"));
            driver.FindElement(By.LinkText("https://www.epam.com/about/who-we-are/contact"));

            Assert.That(driver.Url, Is.EqualTo(epamUrl), "Incorrect URL is present after navigation to main EPAM page!");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }
    }
}