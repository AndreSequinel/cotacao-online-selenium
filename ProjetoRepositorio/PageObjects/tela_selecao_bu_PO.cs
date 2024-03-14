using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRepositorio.PageObjects
{
    public class tela_selecao_bu_PO
    {
        private IWebDriver driver;

        private By ByEmpresa;
        private By ByUnidadeDeNegocio;
        private By ByBotaoEntrar;

        public tela_selecao_bu_PO(IWebDriver driver)
        {
            this.driver = driver;

            ByEmpresa = By.Id("cboEmpresa");
            ByUnidadeDeNegocio = By.Id("cboFilial");
            ByBotaoEntrar = By.Id("bt_entrar");
        }

        public void SelecionarBu2400()
        {
            IWebElement empresaDanone = driver.FindElement(ByEmpresa);
            SelectElement dropdownEmpresaDanone = new SelectElement(empresaDanone);
            dropdownEmpresaDanone.SelectByText("DANONE");

            IWebElement bu2400 = driver.FindElement(ByUnidadeDeNegocio);
            SelectElement dropdownBu2400 = new SelectElement(bu2400);
            dropdownBu2400.SelectByValue("20");
        }
        public void SelecionarBu2300()
        {
            IWebElement empresaSupporte = driver.FindElement(ByEmpresa);
            SelectElement dropdownEmpresaSupporte = new SelectElement(empresaSupporte);
            dropdownEmpresaSupporte.SelectByText("SUPPORT");

            IWebElement bu23 = driver.FindElement(ByEmpresa);
            SelectElement dropdownBu23 = new SelectElement(bu23);
            dropdownBu23.SelectByValue("23");
        }

        public void EntrarAposSelecionarBu()
        {
            driver.FindElement(ByBotaoEntrar).Click();
        }
    }

}
