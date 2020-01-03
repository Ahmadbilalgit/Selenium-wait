using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace No_Such_Element_Exception_Handle
{
  

    class Entrypoint
    {
        static void Main()
        {


            IWebDriver driver = new ChromeDriver("./");
            driver.Navigate().GoToUrl("http://116.203.214.214/");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4000);

            IWebElement Userid = driver.FindElement(By.Name("email"));
            Userid.Click();
            Userid.SendKeys("test@abc.com");


            IWebElement password = driver.FindElement(By.Name("password"));
            password.Click();
            password.SendKeys("abc");
            //Thread.Sleep(3000);

            
            //var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3000));
            // wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div/div/div/div/div/div/form/div[5]/btton")));

            IWebElement Button = driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[5]/button"));
            Button.Click();

            if (Button.Displayed)

            {

                System.Console.WriteLine("The element found");

            }

            else
            {

                System.Console.WriteLine("The element not found");

            }

            driver.Close();
            driver.Quit();
        }


    }
}
