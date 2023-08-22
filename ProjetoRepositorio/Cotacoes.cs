using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace ProjetoRepositorio
{
    public class BuscandoInformações
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            driver = new FirefoxDriver();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void ProcurarValorDolar()
        {
            driver.Url = "https://www.google.com.br/?hl=pt-BR";
            driver.FindElement(By.Id("APjFqb")).SendKeys("Cotação dolar");
            driver.FindElement(By.Id("APjFqb")).SendKeys(Keys.Enter);
            IWebElement ValorDolar = driver.FindElement(By.CssSelector(".SwHCTb"));
            Console.WriteLine("O preço do Dolar é: " + ValorDolar.Text);
        }

        [Test]
        public void ProcurarValorEuro()
        {
            driver.Url = "https://www.google.com.br/?hl=pt-BR";
            driver.FindElement(By.Id("APjFqb")).SendKeys("Cotação Euro");
            driver.FindElement(By.Id("APjFqb")).SendKeys(Keys.Enter);
            IWebElement ValorEuro = driver.FindElement(By.CssSelector(".SwHCTb"));
            Console.WriteLine("O preço do Euro é: " + ValorEuro.Text);
        }

        [TearDown]
        public void FecharNavegador()
        {
            driver.Close();
        }



    }
}