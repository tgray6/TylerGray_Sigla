using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace TylerGray_Sigla {
    public static class Config {
        public static readonly int ElementsWaitingTimeout = 10;
        public static readonly string TestURL = "http://sigla-test-client.us-east-1.elasticbeanstalk.com/";

        public static class LoginCredentials {
            public static class Valid {
                public static readonly string validUsername = "groot";
                public static readonly string validPassword = "iamgroot";
            }

            public static class Invalid {
                public static readonly string invalidUsername = "TestUser";
                public static readonly string invalidPassword = "TestPassword";
            }
        }
    }
}