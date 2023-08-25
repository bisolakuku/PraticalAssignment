using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticalAssignment.Basehook
{
    public class Basepage
    {
        public WebDriver Browser;
        [SetUp]
        public void start()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--start-mazimized");
            Browser = new ChromeDriver(options);
            Browser.Navigate().GoToUrl(Utilities.AutoExercise.PraticalUrl);
        }

        [TearDown]
        public void End() 
        {
            Browser.Quit();
        }

    }
}
