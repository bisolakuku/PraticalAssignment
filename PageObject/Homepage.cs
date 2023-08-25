using PraticalAssignment.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticalAssignment.PageObject
{
    public class Homepage
    {
        IWebDriver driver;
        public Homepage(IWebDriver _driver)
        {
            driver = _driver;
        }
        IWebElement Signup => driver.FindElement(By.PartialLinkText("Signup"));


        public void ClickSignup()=> Signup.Click();
    }
}
