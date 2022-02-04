using System;
using TechTalk.SpecFlow;
using Xunit;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace AutomationGherkin
{
    [Binding]
    public class PerksForSignedInUserStepDefinitions
    {
        //Background
        [Given(@"user is registered and stays on the sign in page")]
        public void GivenUserIsRegisteredAndStaysOnTheSignInPage()
        {
            DriverHolder.driver = new ChromeDriver();
            DriverHolder.driver.Navigate().GoToUrl("http://practice.automationtesting.in/my-account/");
            DriverHolder.driver.Manage().Window.FullScreen();
        }

        [Given(@"user clicks My account button")]
        public void GivenUserClicksMyAccountButton()
        {
            DriverHolder.driver.FindElement(By.XPath("//a[contains(text(),'My Account')]")).Click(); 
        }

        [Given(@"user inputs his '([^']*)'")]
        public void GivenUserInputsHis(string login)
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@id='username']")).SendKeys(login);
        }

        [Given(@"user types his '([^']*)'")]
        public void GivenUserTypesHis(string password)
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@id='password']")).SendKeys(password);
        }

        [Given(@"user clicks on ""([^""]*)"" button")]
        public void GivenUserClicksOnButton(string register)
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@name='login']")).Click();
            DriverHolder.driver.Manage().Window.FullScreen();
        }

        [Given(@"user is on the starting page of his account")]
        public void GivenUserIsOnTheStartingPageOfHisAccount()
        {
            DriverHolder.driver.Navigate().GoToUrl("http://practice.automationtesting.in/my-account/");
            DriverHolder.driver.Navigate().Refresh();
        }
        //Scenario1
        [When(@"user clicks on Log out button")]
        public void WhenUserClicksOnLogOutButton()
        {
            DriverHolder.driver.FindElement(By.XPath("//a[@href='http://practice.automationtesting.in/my-account/customer-logout/']")).Click();
        }

        [Then(@"user goes back to sign in page")]
        public void ThenUserGoesBackToSignInPage()
        {
            DriverHolder.driver.Manage().Window.FullScreen();
            IWebElement element = DriverHolder.driver.FindElement(By.XPath("//div[@id='customer_login']/div/h2"));
            string actual = element.Text;
            string expected = "Login";
            Assert.Equal(expected, actual);
            DriverHolder.driver.Quit();
        }
        //Scenario2
        [When(@"clicks Account details")]
        public void WhenClicksAccountDetails()
        {
           
            DriverHolder.driver.FindElement(By.XPath("//div[@id='page-36']/div/div/nav/ul/li[5]/a")).Click();
            DriverHolder.driver.Navigate().GoToUrl("http://practice.automationtesting.in/my-account/edit-account/");
        }

        [When(@"types '([^']*)' as his first name")]
        public void WhenTypesAsHisFirstName(string petya)
        {
            DriverHolder.driver.Navigate().Refresh();
            DriverHolder.driver.FindElement(By.XPath("//input[@id='account_first_name']")).SendKeys(petya);
        }

        [When(@"inputs '([^']*)' as last name")]
        public void WhenInputsAsLastName(string petrov)
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@id='account_last_name']")).SendKeys(petrov);
        }
        
        [When(@"pushes Save change button")]
        public void WhenPushesSaveChangeButton()
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@name='save_account_details']")).Click();
        }

        [Then(@"user watches his login '([^']*)' on the starting page")]
        public void ThenUserWatchesHisLoginOnTheStartingPage(string p0)
        {
            DriverHolder.driver.Manage().Window.FullScreen();
            IWebElement element = DriverHolder.driver.FindElement(By.XPath("//strong[contains(.,'slavutich765')]"));
            string actual = element.Text;
            Assert.Equal(p0, actual);
            DriverHolder.driver.Quit();
        }

        // Scenario 3
        [When(@"user chooses Billing Addresses")]
        public void WhenUserChoosesBillingAddresses()
        {
            DriverHolder.driver.Navigate().GoToUrl("http://practice.automationtesting.in/my-account/edit-address/billing/");
        }

        [When(@"user types his name '([^']*)'")]
        public void WhenUserTypesHisName(string petya)
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@id='billing_first_name']")).SendKeys(petya);
        }

        [When(@"user inputs his surname '([^']*)'")]
        public void WhenUserInputsHisSurname(string petrov)
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@id='billing_last_name']")).SendKeys(petrov);
        }

        [When(@"user edits telephone '([^']*)'")]
        public void WhenUserEditsTelephone(string p0)
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@id='billing_phone']")).SendKeys(p0);
        }

        [When(@"user clarifies his Address '([^']*)'")]
        public void WhenUserClarifiesHisAddress(string p0)
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@id='billing_address_1']")).SendKeys(p0);
        }

        [When(@"user chooses city '([^']*)'")]
        public void WhenUserChoosesCity(string dnipro)
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@id='billing_city']")).SendKeys(dnipro);
        }
        
        [When(@"inputs postcode '([^']*)'")]
        public void WhenInputsPostcode(string p0)
        {
            DriverHolder.driver.FindElement(By.XPath(" //input[@id='billing_postcode']")).SendKeys(p0);
        }

        [When(@"clicks Save address button")]
        public void WhenClicksSaveAddressButton()
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@name='save_address']")).Click();
        }
        
        [Then(@"users watches a message '([^']*)'")]
        public void ThenUsersWatchesAMessage(string p0)
        {
            DriverHolder.driver.Manage().Window.FullScreen();
            IWebElement element = DriverHolder.driver.FindElement(By.XPath("//div[@id='page-36']/div/div/div"));
            string actual = element.Text;
            Assert.Equal(p0, actual);
            DriverHolder.driver.Quit();
        }

        //Scenario4
        [When(@"user chooses Shipping Addresses")]
        public void WhenUserChoosesShippingAddresses()
        {
            DriverHolder.driver.Navigate().GoToUrl("http://practice.automationtesting.in/my-account/edit-address/shipping/");
        }

        [When(@"user writes his name '([^']*)'")]
        public void WhenUserWritesHisName(string petya)
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@id='shipping_first_name']")).SendKeys(petya);
        }

        [When(@"user confirms his surname '([^']*)'")]
        public void WhenUserConfirmsHisSurname(string petrov)
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@id='shipping_last_name']")).SendKeys(petrov);
        }

        [When(@"user specifies address of shipping '([^']*)'")]
        public void WhenUserSpecifiesAddressOfShipping(string p0)
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@id='shipping_address_1']")).SendKeys(p0);
        }

        [When(@"user inputs city '([^']*)'")]
        public void WhenUserInputsCity(string dnipro)
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@id='shipping_city']")).SendKeys(dnipro);
        }

        [When(@"types postcode '([^']*)'")]
        public void WhenTypesPostcode(string p0)
        {
            DriverHolder.driver.FindElement(By.XPath("//p[@id='shipping_postcode_field']/input")).SendKeys(p0);
        }

        [When(@"types state '([^']*)'")]
        public void WhenTypesState(string dnipropetrovska)
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@id='shipping_state']")).SendKeys(dnipropetrovska);
        }

        [When(@"pushes Save address button")]
        public void WhenPushesSaveAddressButton()
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@name='save_address']")).Click();
        }

        [Then(@"user can watch a message '([^']*)'")]
        public void ThenUserCanWatchAMessage(string p0)
        {
            DriverHolder.driver.Manage().Window.FullScreen();
            IWebElement element = DriverHolder.driver.FindElement(By.XPath("//div[@id='page-36']/div/div/div"));
            string actual = element.Text;
            Assert.Equal(p0, actual);
            DriverHolder.driver.Quit();
        }

    }
}
