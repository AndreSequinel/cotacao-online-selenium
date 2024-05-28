using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace ProjetoRepositorio.Utils;

internal class MasterDataUtils
{
    public static void EsperarElementoEstarVisivel(IWebDriver driver, WebDriverWait wait, By ByWebElement)
    {
        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        wait.Until(ExpectedConditions.ElementIsVisible(ByWebElement));
    }
}
