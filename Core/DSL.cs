using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webscrapSelenium.Core
{
    public class DSL
    {
        static GlobalVariables _global;

        public DSL(GlobalVariables global)
        {
            _global = global;
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments(new List<string>() { "headless", "no-sandbox" });

            _global.driver = new ChromeDriver(chromeOptions);
        }

        public static void EscreveTexto(string xpath, string value)
        {

            _global.driver.FindElement(By.Id(xpath)).SendKeys(value);
        }

        public void ClicaElemento(string xpath)
        {
            _global.driver.FindElement(By.XPath(xpath)).Click();
        }
    }
}
