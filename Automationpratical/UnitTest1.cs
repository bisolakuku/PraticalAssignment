using PraticalAssignment.Basehook;
using PraticalAssignment.PageObject;
using PraticalAssignment.Utilities;

namespace PraticalAssignment
{
    public class AssignmentTest : Basepage
    {

        [Test]
        public void PracticalTest()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--start-mazimized");
            WebDriver Browser = new ChromeDriver(options);
            Browser.Navigate().GoToUrl(Utilities.AutoExercise.PraticalUrl);

            Browser.FindElement(By.PartialLinkText("Signup")).Click();

            Browser.FindElement(By.XPath("//input[@data-qa='signup-name']")).SendKeys("Beecee");

            Browser.FindElement(By.XPath("//input[@data-qa='signup-email']")).SendKeys("dee@yahoo.com");

            Browser.FindElement(By.CssSelector("[data-qa='signup-button']")).Click();

            Browser.FindElements(By.Name("title"))[1].Click();

            Browser.FindElement(By.Id("password")).SendKeys("tdhajdj");

            SelectElement daydown = new SelectElement(Browser.FindElement(By.Id("days")));
            daydown.SelectByText("9");

            SelectElement Mnthdrpdown = new SelectElement(Browser.FindElement(By.Id("months")));
            Mnthdrpdown.SelectByText("July");

            SelectElement Yrdrpdown = new SelectElement(Browser.FindElement(By.Id("years")));
            Yrdrpdown.SelectByValue("1988");

            //Browser.FindElements(By.TagName("newsletter"))[0].Click();

            Browser.FindElement(By.CssSelector("[data-qa='first_name']")).SendKeys("Ray");

            Browser.FindElement(By.Id("last_name")).SendKeys("Cherish");

            Browser.FindElement(By.XPath("//input[@data-qa='company']")).SendKeys("XYZ");

            Browser.FindElement(By.Name("address1")).SendKeys("crookes road");

            SelectElement ctrydrpdown = new SelectElement(Browser.FindElement(By.Id("country")));
            ctrydrpdown.SelectByText("Australia");

            Browser.FindElement(By.CssSelector("[data-qa='state']")).SendKeys("Sydney");

            Browser.FindElement(By.CssSelector("[data-qa='city']")).SendKeys("Canberra");

            Browser.FindElement(By.XPath("//input[@data-qa='zipcode']")).SendKeys("839SNX");

            Browser.FindElement(By.Id("mobile_number")).SendKeys("7463536478");

            IJavaScriptExecutor js = (IJavaScriptExecutor)Browser;
            js.ExecuteScript("arguments[0].click();", Browser.FindElement(By.CssSelector("[data-qa='create-account']")));


            Thread.Sleep(5000);
            Browser.Quit();
        }

        [Test]
        public void POMTest()
        {
            Homepage homepage = new Homepage(Browser);  
            homepage.ClickSignup();

            Signup_page signup_Page = new Signup_page(Browser);
            signup_Page.fillSignupForm("bisi", $"hsv{new Random().Next(1, 999)}@yahoo.com");

            EnterAcctInfo enterAcctInfo = new EnterAcctInfo(Browser);
            enterAcctInfo.fillEnterAcctInfoform("1", "ydhsga", "20", "july", "1988", "0", "Biso", 
                "kuku", "XYZ", "16 Toteham street", "canada", "yorkshire","sheffield", "Dt3 7rj", "7438748390");

            //Login login = new Login(Browser);
            //login.clickLogin();
        }

        
        
    }
}