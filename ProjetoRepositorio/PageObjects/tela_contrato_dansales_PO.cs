using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ProjetoRepositorio.PageObjects
{
    public class tela_contrato_dansales_PO
    {
        private IWebDriver driver;

        public tela_contrato_dansales_PO(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
