using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestesAutDansales.PageObjects
{
    public class tela_login_dansales_PO
    {
        private IWebDriver driver;

        private By ByBotaoLoginSemSso;
        private By ByBotaoLogin;
        private By ByBotaoSenha;
        private By ByBotaoEntrar;

        private string usuario;
        private string senha;

        public tela_login_dansales_PO(IWebDriver driver)
        {
            this.driver = driver;

            ByBotaoLoginSemSso = By.Id("bt_externo");
            ByBotaoLogin = By.Id("txtUserName");
            ByBotaoSenha = By.Id("txtPassword");
            ByBotaoEntrar = By.Id("bt_entrar");
            usuario = "0";
            senha = "D@none03";            
        }

        public void NavegarParaUrl()
        {
            driver.Navigate().GoToUrl("https://dansaleswebdev.danone.com.br/homolog/Login");
            driver.FindElement(ByBotaoLoginSemSso).Click();
        }

        public void PreencherDadosTelaDeLogin()
        {
            driver.FindElement(ByBotaoLogin).Click();
            driver.FindElement(ByBotaoLogin).SendKeys(usuario);
            driver.FindElement(ByBotaoSenha).Click();
            driver.FindElement(ByBotaoSenha).SendKeys(senha);
        }

        public void EfetuarAcaoDeLogin()
        {
            driver.FindElement(ByBotaoEntrar).Click();
        }

        public void AcoesAposLogar()
        {
            driver.FindElement(By.LinkText("Cadastro")).Click();
            //driver.FindElement(By.LinkText("Manutenção de Contratos")).Click();
            //driver.FindElement(By.CssSelector("#collapseFive .row:nth-child(1) .subtitulo")).Click();
            //driver.FindElement(By.Id("bt_incluir")).Click();
            //driver.FindElement(By.Id("ddlUf")).Click();
            //var dropdown = driver.FindElement(By.Id("ddlUf"));
            //dropdown.FindElement(By.XPath("//option[. = 'CE']")).Click();
        }
    }
}
