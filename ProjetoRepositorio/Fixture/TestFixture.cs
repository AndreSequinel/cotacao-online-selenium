using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;

namespace ProjetoRepositorio.Fixture
{
    public class TestFixture : IDisposable
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

        public void Dispose()
        {
            driver.Quit();
        }

    }
}
