using System;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Chrome;
namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://cms.poly.edu.vn/");

            driver.FindElement(By.CssSelector(".sign-in-btn.btn")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Name("email")).SendKeys("phunhph10738@fpt.edu.vn");
            driver.FindElement(By.Name("password")).SendKeys("phu962001");
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".action.action-primary.action-update.js-login.login-button")).Click();
        }

       
    }
}
