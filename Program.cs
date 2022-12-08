using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using webscrapSelenium.Core;

Console.WriteLine("Hello, World!");

string Url = "https://buscacepinter.correios.com.br/app/endereco/index.php";

// seto esta opção para não mostrar o brower rodando.
var chromeOptions = new ChromeOptions();
chromeOptions.AddArguments(new List<string>() { "headless", "no-sandbox" });


var driver = new ChromeDriver(chromeOptions);

driver.Navigate().GoToUrl(Url);
driver.Manage().Window.Maximize();

driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

driver.FindElement(By.Id("endereco")).SendKeys("74594079");
driver.FindElement(By.Id("btn_pesquisar")).Click();

//"//*[@id=\"resultado-DNEC\"]/tbody/tr/td[1]"
//substitua as aspas duplas por aspas simples.
var rua = driver.FindElement(By.XPath("//*[@id='resultado-DNEC']/tbody/tr/td[1]")).Text.ToString();

driver.Quit();

Console.WriteLine(rua);