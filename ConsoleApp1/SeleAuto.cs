using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
namespace ConsoleApp1
{
    public class SeleAuto
    {
        public void Auto()
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
