using OpenQA.Selenium;

namespace ProjetoRepositorio.PageObjects
{
    public class InformacoesPesquisaPO
    {
        private IWebDriver driver;

        private By ByBarraPesquisa;
        private By ByValorDolar;
        private By ByValorEuro;

        public string ValorDolarTexto => driver.FindElement(ByValorDolar).Text;
        public string ValorEuroTexto => driver.FindElement(ByValorEuro).Text;

        public InformacoesPesquisaPO(IWebDriver driver)
        {
            this.driver = driver;

            ByBarraPesquisa = By.Id("APjFqb");
            ByValorDolar = By.CssSelector("span.DFlfde.SwHCTb[data-precision]");
            ByValorEuro = By.CssSelector(".SwHCTb");

        }

        public void NavegarParaUrl()
        {
            driver.Navigate().GoToUrl("https://www.google.com.br/?hl=pt-BR");
        }

        public void PreecherInformacoesPesquisaDolar()
        {
            driver.FindElement(ByBarraPesquisa).SendKeys("Cotação dolar");
            driver.FindElement(ByBarraPesquisa).SendKeys(Keys.Enter);
        }

        public void PreecherInformacoesPesquisaEuro()
        {
            driver.FindElement(ByBarraPesquisa).SendKeys("Cotação euro");
            driver.FindElement(ByBarraPesquisa).SendKeys(Keys.Enter);
        }
    }
}

