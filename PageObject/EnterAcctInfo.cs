using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PraticalAssignment.PageObject
{
    public class EnterAcctInfo
    {
        IWebDriver driver;
        public EnterAcctInfo(IWebDriver _driver)
        {
            driver = _driver;
        }

        IWebElement title => driver.FindElements(By.Name("title"))[1];
        IWebElement password => driver.FindElement(By.Id("password"));
        IWebElement Day => driver.FindElement(By.Id("days"));
        IWebElement Month => driver.FindElement(By.CssSelector("[data-qa='months']"));
        IWebElement Year => driver.FindElement(By.CssSelector("[data-qa='years']"));
        IWebElement newsletter => driver.FindElements(By.Id("newsletter"))[0];
        IWebElement Firstname => driver.FindElement(By.CssSelector("[data-qa='first_name']"));
        IWebElement Lastname => driver.FindElement(By.XPath("//input[@data-qa='last_name']"));
        IWebElement Company => driver.FindElement(By.XPath("//input[@data-qa='company']"));
        IWebElement Address => driver.FindElement(By.CssSelector("[data-qa='address']"));
        IWebElement Country => driver.FindElement(By.Id("country"));
        IWebElement State => driver.FindElement(By.CssSelector("[data-qa='state']"));
        IWebElement City => driver.FindElement(By.CssSelector("[data-qa='city']"));
        IWebElement Zipcode => driver.FindElement(By.XPath("//input[@data-qa='zipcode']"));
        IWebElement MobileNumber => driver.FindElement(By.Id("mobile_number"));
        IWebElement CreateAccount => driver.FindElement(By.XPath("//button[@data-qa='create-account']"));

        public void fillEnterAcctInfoform(string Title, string Password,
            string day, string month, string year, string Newsletter, string firstname,string lastname,string company,
            string address, string country,string state, string city, string zipcode, string mobilenumber)
        {
            title.Click();
            password.SendKeys(Password);
            Day.SendKeys(day);
            Month.SendKeys(month);
            Year.SendKeys(year);
            newsletter.SendKeys(Newsletter);
            Firstname.SendKeys(firstname);
            Lastname.SendKeys(lastname);
            Company.SendKeys(company);
            Address.SendKeys(address);
            Country.SendKeys(country);
            State.SendKeys(state);
            City.SendKeys(city);
            Zipcode.SendKeys(zipcode);
            MobileNumber.SendKeys(mobilenumber);
            CreateAccount.Click();
        }
    }
}
