using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TylerGray_Sigla {

    public class LoginUI {
        //Constructor
        public LoginUI(IWebDriver driver) {
            PageFactory.InitElements(driver, this);
        }

        //Username Input Field
        [FindsBy(How = How.CssSelector, Using = "#mat-input-0")]
        public IWebElement UsernameInput { get; set; }

        //Password input field
        [FindsBy(How = How.CssSelector, Using = "#mat-input-1")]
        public IWebElement PasswordInput { get; set; }

        //Login button Deactivated
        [FindsBy(How = How.CssSelector, Using = "mat-sidenav-container.mat-drawer-container.mat-sidenav-container mat-sidenav-content.mat-drawer-content.mat-sidenav-content.ng-star-inserted:nth-child(5) app-login.ng-star-inserted:nth-child(2) mat-card.login-card.mat-card form.example-form.ng-untouched.ng-pristine.ng-invalid div:nth-child(1) div:nth-child(1) div:nth-child(3) div:nth-child(1) > button.mat-raised-button.mat-button-base.mat-primary:nth-child(1)")]
        public IWebElement SignInButtonDeactive { get; set; }

        //Login button Active
        [FindsBy(How = How.CssSelector, Using = "mat-sidenav-container.mat-drawer-container.mat-sidenav-container mat-sidenav-content.mat-drawer-content.mat-sidenav-content.ng-star-inserted:nth-child(5) app-login.ng-star-inserted:nth-child(2) mat-card.login-card.mat-card form.example-form.ng-dirty.ng-touched.ng-valid div:nth-child(1) div:nth-child(1) div:nth-child(3) div:nth-child(1) > button.mat-raised-button.mat-button-base.mat-primary:nth-child(1)")]
        public IWebElement SignInButtonActive { get; set; }

        //Forgot password link
        [FindsBy(How = How.CssSelector, Using = "mat-sidenav-container.mat-drawer-container.mat-sidenav-container mat-sidenav-content.mat-drawer-content.mat-sidenav-content.ng-star-inserted:nth-child(5) app-login.ng-star-inserted:nth-child(2) mat-card.login-card.mat-card form.example-form.ng-pristine.ng-invalid.ng-touched div:nth-child(1) div:nth-child(1) div:nth-child(3) div:nth-child(1) > a:nth-child(2)")]
        public IWebElement ForgotYourPassword { get; set; }
    }
}

