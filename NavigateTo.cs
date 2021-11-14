using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TylerGray_Sigla {
    class NavigateTo {

        //In a more complex site, this class would be used to navigate to different components in simple english by typing "NavigateTo.(Insert Where to go). Below is an example of how we would go to MY PROFILE by passing in the driver in the actual test

        //NavigateTo.MyProfile(driver);

        public static void MyProfile(IWebDriver driver) {
            HeaderUI header = new HeaderUI(driver);

            header.MyProfileButton.Click();
        }
    }
}
