using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using webscrapSelenium.Core;

Console.WriteLine("iniciando");


Testar();

void Testar()
{
    string url = "http://usuario:senha@192.168.0.118";
    var driver = new ChromeDriver();

    driver.Navigate().GoToUrl(url);
    driver.Manage().Window.Maximize();

    Thread.Sleep(6000);
    string teste = driver.FindElement(By.XPath("/html/body/table/tbody/tr[1]/td/p/a")).Text.ToString();
    Console.WriteLine(teste);

}

void Primeiro()
{
    string Url = "https://buscacepinter.correios.com.br/app/endereco/index.php";

    // seto esta opção para não mostrar o brower rodando.
    //var chromeOptions = new ChromeOptions();
    //chromeOptions.AddArguments(new List<string>() { "headless", "no-sandbox" });


    //var driver = new ChromeDriver(chromeOptions);
    var driver = new ChromeDriver();

    driver.Navigate().GoToUrl(Url);
    driver.Manage().Window.Maximize();

    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

    driver.FindElement(By.Id("endereco")).SendKeys("74594079");
    driver.FindElement(By.Id("btn_pesquisar")).Click();

    //"//*[@id=\"resultado-DNEC\"]/tbody/tr/td[1]"
    //substitua as aspas duplas por aspas simples.
    var rua = driver.FindElement(By.XPath("//*[@id='resultado-DNEC']/tbody/tr/td[1]")).Text.ToString();

    //IJavaScriptExecutor js = driver as IJavaScriptExecutor;
    //js.ExecuteScript("alert('oi testando alerta!')");
    //System.Threading.Thread.Sleep(6000);
    //IAlert alert = driver.SwitchTo().Alert();
    //alert.Accept();

    driver.Quit();

    Console.WriteLine(rua);
}