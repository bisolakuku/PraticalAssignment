using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticalAssignment.PageObject
{
    public class Signup_page
    {
        IWebDriver driver;
        public Signup_page(IWebDriver _driver)
        {
            driver = _driver;    
        }

        IWebElement name => driver.FindElement(By.CssSelector("input[data-qa='signup-name']"));
        IWebElement email => driver.FindElement(By.CssSelector("input[data-qa='signup-email']"));
        IWebElement Signup => driver.FindElement(By.CssSelector("[data-qa='signup-button']"));

        public void fillSignupForm(string Name, string Email)
        {
            name.SendKeys(Name);
            email.SendKeys(Email);
            Signup.Click();
        }
    }
}
