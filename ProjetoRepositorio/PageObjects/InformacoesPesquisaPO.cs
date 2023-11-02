using OpenQA.Selenium;

namespace ProjetoRepositorio.PageObjects
{
    public class InformacoesPesquisaPO
    {
        private IWebDriver driver;

        private By ByBarraPesquisa;
        private By ByValorDolar;

        public string ValorDolarTexto => driver.FindElement(ByValorDolar).Text;

        public InformacoesPesquisaPO(IWebDriver driver)
        {
            this.driver = driver;

            ByBarraPesquisa = By.Id("APjFqb");
            ByValorDolar = By.CssSelector("span.DFlfde.SwHCTb[data-precision]");

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
    }
}

