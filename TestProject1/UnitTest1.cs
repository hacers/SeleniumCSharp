using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestProject1
{
    public class Tests: DriverHelper
    {
       
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            
            
        }

        [Test]
        public void Test1()
        {
           
            driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
           // driver.Manage().Window.FullScreen();
            IWebElement input1 = driver.FindElement(By.Id("ContentPlaceHolder1_Meal"));
            input1.SendKeys("tomato");
            driver.FindElement(By.XPath("(//*[@class='awe-display o-ochk']/ul/li)[1]")).Click();
            
            //driver.FindElement(By.XPath("//div[@id='ContentPlaceHolder1_AllMealsCombo - dropmenu']//li[text()='Almond']")).Click();
            //SelectElement selectElemet = new SelectElement(input1);
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");
            Assert.Pass();
            driver.Close();
        }
    }
}