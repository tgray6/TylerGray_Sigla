using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace TylerGray_Sigla.Scenarios {

    [Parallelizable]
    class Login {

        private IWebDriver Driver { get; set; }

        //CSS Selectors
        private string _welcomeTextCSSPath = "mat-sidenav-container.mat-drawer-container.mat-sidenav-container mat-sidenav-content.mat-drawer-content.mat-sidenav-content.ng-star-inserted:nth-child(5) app-portal.ng-star-inserted:nth-child(2) div.portal > div:nth-child(1)";
        private string _deactivatedLoginButtonCSSPath = "mat-sidenav-container.mat-drawer-container.mat-sidenav-container mat-sidenav-content.mat-drawer-content.mat-sidenav-content.ng-star-inserted:nth-child(5) app-login.ng-star-inserted:nth-child(2) mat-card.login-card.mat-card form.example-form.ng-untouched.ng-pristine.ng-invalid div:nth-child(1) div:nth-child(1) div:nth-child(3) div:nth-child(1) > button.mat-raised-button.mat-button-base.mat-primary:nth-child(1)";

        //Response messages from Site, used for Assert.AreEqual
        private string _welcomeToPortalText = "This Text Is Meant To Fail To Show The Assertion Error";


        [OneTimeSetUp]
        public void Initialize() {
            Driver = Action.InitializeDriver();
        }

        //SignIn_01: Sign in with empty fields and verify: login button is unclickable
        [Test]
        public void SignInEmptyFields() {
            LoginUI login = new LoginUI(Driver);
            login.SignInButtonDeactive.Click();
            Assert.AreEqual(true, Driver.FindElement(By.CssSelector(_deactivatedLoginButtonCSSPath)).Displayed);
        }

        //SignIn_08: Sign in with valid username and valid password and verify: redirect to Sigla Portal and success text "Welcome to the portal, Groot". 
        [Test]
        public void SignInSuccess() {
            CreateRecipeUI createRecipe = new CreateRecipeUI(Driver);
            Action.FillLoginForm(Config.LoginCredentials.Valid.validUsername, Config.LoginCredentials.Valid.validPassword, Driver);
            Action.WaitForCssElement(_welcomeTextCSSPath, Driver);
            Assert.AreEqual(_welcomeToPortalText, createRecipe.WelcomeText.Text);
        }


        [OneTimeTearDown]
        public void TearDown() {
            Driver.Quit();
        }
    }
}
