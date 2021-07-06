using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1
{
    public class CustomControl: DriverHelper
    {
        public static void ComboBox(string controlName, string value)
        {
            IWebElement comboBox1 = driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));
            //ContentPlaceHolder1_AllMealsCombo
            comboBox1.Clear();
            comboBox1.SendKeys(value);
        }
    }
}
