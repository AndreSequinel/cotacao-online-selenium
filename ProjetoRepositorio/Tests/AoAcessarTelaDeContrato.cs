using ProjetoRepositorio.Fixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoRepositorio.PageObjects;
using OpenQA.Selenium;

namespace TestesAutDansales.Tests
{
    public class AoAcessarTelaDeContrato : TestFixture
    {
        public void Setup(TestFixture fixture)
        {
            fixture.driver = driver;
        }


    }
}
