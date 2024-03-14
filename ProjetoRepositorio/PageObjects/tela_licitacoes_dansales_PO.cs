using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesAutDansales.PageObjects
{
    public class tela_licitacoes_dansales_PO
    {
        private IWebDriver driver;

        private By ByBotaoAcessarModuloLicitacoes;
        private By ByAcessarCampoDeRelatorios;

        public tela_licitacoes_dansales_PO(IWebDriver driver)
        {
            this.driver = driver;

            ByBotaoAcessarModuloLicitacoes = By.LinkText("Licitações");
            ByAcessarCampoDeRelatorios = By.LinkText("Relatórios");
        }

        public void AcessarRelatoriosEmLicitacoes()
        {
            driver.FindElement(ByBotaoAcessarModuloLicitacoes).Click();
            driver.FindElement(ByAcessarCampoDeRelatorios).Click();
        }
    }
}
