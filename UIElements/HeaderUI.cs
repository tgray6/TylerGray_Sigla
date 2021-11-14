using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TylerGray_Sigla {
    public class HeaderUI {

        public HeaderUI(IWebDriver driver) {
            PageFactory.InitElements(driver, this);
        }

        //My Profile Icon
        [FindsBy(How = How.CssSelector, Using = "body:nth-child(2) app-root:nth-child(1) mat-toolbar.mat-toolbar.mat-toolbar-single-row div.ng-star-inserted:nth-child(4) > button.mat-icon-button.mat-button-base")]
        public IWebElement MyProfileButton { get; set; }
    }
}
