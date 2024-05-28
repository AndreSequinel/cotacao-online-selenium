using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;

namespace ProjetoRepositorio.Fixture
{
    [TestFixture]
    public class TestFixture
    {
        public IWebDriver driver;

        [SetUp]
        public void InicializarDriver()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            driver = new FirefoxDriver();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void Dispose()
        {
            driver.Dispose();
        }

    }
}
