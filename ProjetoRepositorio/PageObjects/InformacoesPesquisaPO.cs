using OpenQA.Selenium;
using ProjetoRepositorio.Utils;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace ProjetoRepositorio.PageObjects
{
    public class InformacoesPesquisaPO
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        private By ByBarraPesquisa;
        private By ByValorDolar;
        private By ByValorEuro;

        public string ValorDolarTexto => driver.FindElement(ByValorDolar).Text;
        public string ValorEuroTexto => driver.FindElement(ByValorEuro).Text;

        public InformacoesPesquisaPO(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

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
            MasterDataUtils.EsperarElementoEstarVisivel(driver, wait, ByBarraPesquisa);

            driver.FindElement(ByBarraPesquisa).SendKeys("Cotação dolar");
            driver.FindElement(ByBarraPesquisa).SendKeys(Keys.Enter);
        }

        public void PreencherInformacoesPesquisaEuro()
        {
            MasterDataUtils.EsperarElementoEstarVisivel(driver, wait, ByBarraPesquisa);

            driver.FindElement(ByBarraPesquisa).SendKeys("Cotação Euro");
            driver.FindElement(ByBarraPesquisa).SendKeys(Keys.Enter);
        }
    }
}

