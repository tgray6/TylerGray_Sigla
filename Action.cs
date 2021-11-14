using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace TylerGray_Sigla {
    class Action {

        //***************************CHANGE DRIVER HERE (FIREFOX, EDGE, CHROME)************************
        public static IWebDriver InitializeDriver() {
            /*----------CHROME DRIVER----------*///
            ChromeOptions chromeOptions = new ChromeOptions();
            IWebDriver driver = new ChromeDriver(chromeOptions);

            ///*---------FIREFOX DRIVER----------*///
            //IWebDriver driver = new FirefoxDriver();

            /*----------EDGE DRIVER------------
            EDGE DRIVER IS NOT IMPLEMENTED FOR THIS PROJECT
            /*/

            //var service = EdgeDriverService.CreateDefaultService(@"C:\Selenium\edgedriver", @"msedgedriver.exe");
            //IWebDriver driver = new EdgeDriver(service);


            driver.Navigate().GoToUrl(Config.TestURL);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Config.ElementsWaitingTimeout);
            driver.Manage().Window.Maximize();

            return driver;
        }

        //Wait for a specific CSS element to appear before test continues
        public static void WaitForCssElement(string element, IWebDriver driver) {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(Config.ElementsWaitingTimeout));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector(element)));
        }

        //Wait for a specific XPath to appear before test continues
        public static void WaitForXPathElement(string element, IWebDriver driver) {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(Config.ElementsWaitingTimeout));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(element)));
        }


        public static void FillLoginForm(string username, string password, IWebDriver driver) {
            LoginUI signInForm = new LoginUI(driver);

            signInForm.UsernameInput.Click();

            signInForm.UsernameInput.SendKeys(Keys.Control + "a" + Keys.Backspace);
            signInForm.PasswordInput.SendKeys(Keys.Control + "a" + Keys.Backspace);

            signInForm.UsernameInput.SendKeys(username);
            signInForm.PasswordInput.SendKeys(password);

            signInForm.SignInButtonActive.Click();
        }

    }
}
