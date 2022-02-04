using System;
using TechTalk.SpecFlow;
using Xunit;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace AutomationGherkin
{
    [Binding]
    public class ResetPasswordStepDefinitions
    {
        [Given(@"user is logged out and stayes on the sign in page")]
        public void GivenUserIsLoggedOutAndStayesOnTheSignInPage()
        {
            DriverHolder.driver = new ChromeDriver();
            DriverHolder.driver.Navigate().GoToUrl("http://practice.automationtesting.in/my-account/");
            DriverHolder.driver.Manage().Window.FullScreen();
            DriverHolder.driver.Navigate().Refresh();
        }
        //Scenario1
        [When(@"user clicks on Lost your password button")]
        public void WhenUserClicksOnLostYourPasswordButton()
        {
            DriverHolder.driver.FindElement(By.XPath("//a[contains(text(),'Lost your password?')]")).Click();
            DriverHolder.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }

        [When(@"inputs his current email address '([^']*)'")]
        public void WhenInputsHisCurrentEmailAddress(string p0)
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@id='user_login']")).SendKeys(p0);
        }

        [When(@"clicks reset button")]
        public void WhenClicksResetButton()
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@value='Reset Password']")).Click();
        }

        [Then(@"user sees a message '([^']*)'")]
        public void ThenUserSeesAMessage(string p0)
        {
            DriverHolder.driver.Manage().Window.FullScreen();
            IWebElement element = DriverHolder.driver.FindElement(By.XPath("//p[contains(.,'A password reset email has been sent to the email address on file for your account, but may take several minutes to show up in your inbox. Please wait at least 10 minutes before attempting another reset.')]"));
            string actual = element.Text;
            Assert.Equal(p0, actual);
            DriverHolder.driver.Quit();
        }

        //Scenario2
        [When(@"user inputs his email '([^']*)'")]
        public void WhenUserInputsHis(string p0)
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@id='username']")).SendKeys(p0);
        }

        [When(@"user types his password '([^']*)'")]
        public void WhenUserTypesHis(string p0)
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@id='password']")).SendKeys(p0);
        }

        [When(@"user clicks on ""([^""]*)"" button")]
        public void WhenUserClicksOnButton(string login)
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@name='login']")).Click();
            DriverHolder.driver.Manage().Window.FullScreen();
        }

        [When(@"user is on the starting page of his account")]
        public void WhenUserIsOnTheStartingPageOfHisAccount()
        {
            DriverHolder.driver.Navigate().GoToUrl("http://practice.automationtesting.in/my-account/");
            DriverHolder.driver.Navigate().Refresh();
        }

        [When(@"user pushes button Account details")]
        public void WhenUserPushesButtonAccountDetails()
        {
            DriverHolder.driver.FindElement(By.XPath("//div[@id='page-36']/div/div/nav/ul/li[5]/a")).Click();
            DriverHolder.driver.Navigate().GoToUrl("http://practice.automationtesting.in/my-account/edit-account/");
            DriverHolder.driver.Navigate().Refresh();
        }

        [When(@"types '([^']*)' as a current password")]
        public void WhenTypesAsACurrentPassword(string p0)
        { 
            DriverHolder.driver.FindElement(By.XPath("//input[@id='password_current']")).SendKeys(p0);
        }

        [When(@"inputs as a new password '([^']*)'")]
        public void WhenInputsAsANewPassword(string p0)
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@id='password_1']")).SendKeys(p0);
        }

        [When(@"confirms new password '([^']*)'")]
        public void WhenConfirmsNewPassword(string p0)
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@id='password_2']")).SendKeys(p0);
        }

        [When(@"clicks button Save changes")]
        public void WhenClicksButtonSaveChanges()
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@name='save_account_details']")).Click();
        }

        [When(@"user logs out")]
        public void WhenUserLogsOut()
        {
            DriverHolder.driver.FindElement(By.XPath("//a[@href='http://practice.automationtesting.in/my-account/customer-logout/']")).Click();
        }

        [When(@"user inputs his login '([^']*)'")]
        public void WhenUserInputsHisLogin(string p0)
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@id='username']")).SendKeys(p0);
        }

        [When(@"user types as a new password '([^']*)'")]
        public void WhenUserTypesAsANewPassword(string p0)
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@id='password']")).SendKeys(p0);
        }

        [When(@"user pushes on ""([^""]*)"" button")]
        public void WhenUserPushesOnButton(string login)
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@name='login']")).Click();
            DriverHolder.driver.Manage().Window.FullScreen();
            DriverHolder.driver.Navigate().Refresh();
        }

        [Then(@"user can watch his account starting page")]
        public void ThenUserCanWatchHisAccountStartingPage()
        {
            DriverHolder.driver.Manage().Window.FullScreen();
            IWebElement element = DriverHolder.driver.FindElement(By.XPath("//div[@id='page-36']/div/div/div/p/strong"));
            string actual = element.Text;
            string expected = "slavutich12345";
            Assert.Equal(expected, actual);
            DriverHolder.driver.Quit();
        }
    }
}






