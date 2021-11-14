using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TylerGray_Sigla {
    public class CreateRecipeUI {

        public CreateRecipeUI(IWebDriver driver) {
            PageFactory.InitElements(driver, this);
        }

        //Welcome Text
        [FindsBy(How = How.CssSelector, Using = "mat-sidenav-container.mat-drawer-container.mat-sidenav-container mat-sidenav-content.mat-drawer-content.mat-sidenav-content.ng-star-inserted:nth-child(5) app-portal.ng-star-inserted:nth-child(2) div.portal > div:nth-child(1)")]
        public IWebElement WelcomeText { get; set; }
    }
}
