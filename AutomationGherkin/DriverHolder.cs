using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationGherkin
{
    internal class DriverHolder
    {
        public static IWebDriver driver { get; set; }
    }
}
