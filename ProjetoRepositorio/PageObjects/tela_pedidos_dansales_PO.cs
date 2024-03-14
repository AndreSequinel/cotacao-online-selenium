using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesAutDansales.PageObjects
{
    public class tela_pedidos_dansales_PO
    {
        IWebDriver driver;

        private By ByBotaoPedido;
        private By ByFiltroAvancadoPanel;

        public tela_pedidos_dansales_PO(IWebDriver driver)
        {
            this.driver = driver;

            ByBotaoPedido = By.Id("bt_pedidos");
            ByFiltroAvancadoPanel = By.CssSelector(".panel-heading");
        }

        public void AposRealizarLoginAcessarPaginaPedidos()
        {
            //Chamar metodos de login antes
            driver.FindElement(ByBotaoPedido).Click();
        }

        public void AposAcessarTelaPedidoTestarFiltrosAvancados()
        {
            driver.FindElement(ByFiltroAvancadoPanel).Click();
        }

    }
}
