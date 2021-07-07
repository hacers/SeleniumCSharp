using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1.Pages
{
    class Login : DriverHelper
    {
        IWebElement txtUserName => driver.FindElement(By.Name("UserName"));

        IWebElement txtPassword => driver.FindElement(By.Name("Password"));
        IWebElement btnLogin => driver.FindElement(By.XPath("//input[@class='btn btn-default']"));

        public void EnterUsernameAndPassword(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }
        public void ClickLogin()
        {
            btnLogin.Click();
        }

        
    }
}
