using System;
using TechTalk.SpecFlow;
using Xunit;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Windows;

namespace AutomationGherkin
{
    [Binding]
    public class DealWithGoodsStepDefinitions
    {
        //Background
        [Given(@"user is on the page with items")]
        public void GivenUserIsOnThePageWithItems()
        {
            DriverHolder.driver = new ChromeDriver();
            DriverHolder.driver.Navigate().GoToUrl("http://practice.automationtesting.in/shop/");
            DriverHolder.driver.Manage().Window.FullScreen();
        }

        [Given(@"clicks book '([^']*)'")]
        public void GivenClicksBook(string p0)
        {
            DriverHolder.driver.Navigate().GoToUrl("http://practice.automationtesting.in/product/functional-programming-in-js/");
        }

        //Scenario1
        [When(@"user chooses '([^']*)' tab")]
        public void WhenUserChoosesTab(string description)
        {
            DriverHolder.driver.FindElement(By.XPath("//div[@id='product-170']/div[3]/ul/li/a")).Click();
        }

        [Then(@"user can see '([^']*)'")]
        public void ThenUserCanSee(string p0)
        {
            DriverHolder.driver.Manage().Window.FullScreen();
            IWebElement element = DriverHolder.driver.FindElement(By.XPath("//h2[contains(.,'Product Description')]"));
            string actual = element.Text;
            Assert.Equal(p0, actual);
            DriverHolder.driver.Quit();
        }
        //Scenario2

        [When(@"user adds an item to basket")]
        public void WhenUserAddsAnItemToButton()
        {
            DriverHolder.driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        }

        [When(@"user chooses basket")]
        public void WhenUserChoosesBusket()
        {
            DriverHolder.driver.Navigate().GoToUrl("http://practice.automationtesting.in/basket/");
        }

        [Then(@"user watches price to pay")]
        public void ThenUserWatchesPriceToPay()
        {
            DriverHolder.driver.Manage().Window.FullScreen();
            IWebElement element = DriverHolder.driver.FindElement(By.XPath("//div[@id='page-34']/div/div/div/div/table/tbody/tr[3]/td/strong/span"));
            string actual = element.Text;
            string expected = "₹262.50";
            Assert.Equal(expected, actual);
            DriverHolder.driver.Quit();
        }
        //Scenario3
        [When(@"orders an item to basket")]
        public void WhenOrdersAnItemToBasket()
        {
            DriverHolder.driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        }

        [When(@"user is on the basket page")]
        public void WhenUserIsOnTheBasketPage()
        {
            DriverHolder.driver.Navigate().GoToUrl("http://practice.automationtesting.in/basket/");
        }

        [When(@"user proceeds for payment")]
        public void WhenUserProceedsForPayment()
        {
            DriverHolder.driver.FindElement(By.XPath("//a[contains(text(),'Proceed to Checkout')]")).Click();
        }

        [When(@"user types '([^']*)' as his name")]
        public void WhenUserTypesAsHisName(string petya)
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@id='billing_first_name']")).SendKeys(petya);
        }

        [When(@"user types '([^']*)' as surname")]
        public void WhenUserTypesAsSurname(string petrov)
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@id='billing_last_name']")).SendKeys(petrov);
        }

        [When(@"user inputs his Email '([^']*)'")]
        public void WhenUserInputsHisEmail(string p0)
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@id='billing_email']")).SendKeys(p0);
        }

        [When(@"user types his phone number '([^']*)'")]
        public void WhenUserTypesHisPhoneNumber(string p0)
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@id='billing_phone']")).SendKeys(p0);
        }

        [When(@"user inputs his address '([^']*)'")]
        public void WhenUserInputsHisAddress(string gladkova)
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@id='billing_address_1']")).SendKeys(gladkova);
        }

        [When(@"user types his town '([^']*)'")]
        public void WhenUserTypesHisTown(string dnipro)
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@id='billing_city']")).SendKeys(dnipro);
        }

        [When(@"user types his Postcode '([^']*)'")]
        public void WhenUserTypesHisPostcode(string p0)
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@id='billing_postcode']")).SendKeys(p0);
        }

        [When(@"user inputs his state '([^']*)'")]
        public void WhenUserInputsHisState(string dnipropetrovska)
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@id='billing_state']")).SendKeys(dnipropetrovska);
        }

        [When(@"user chooses type of payment '([^']*)'")]
        public void WhenUserChoosesTypeOfPayment(string cheque)
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@id='payment_method_cheque']")).Click();
        }


        [When(@"user clicks Place order button")]
        public void WhenUserClicksPlaceOrderButton()
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@id='place_order']")).Click();
        }

        [Then(@"user sees '([^']*)'")]
        public void ThenUserSees(string p0)
        {
            DriverHolder.driver.Manage().Window.FullScreen();
            IWebElement element = DriverHolder.driver.FindElement(By.XPath("//input[@id='place_order']"));
            string actual = element.Text;
            string expected = "";
            Assert.Equal(expected, actual);
            DriverHolder.driver.Quit();
        }

        //Scenario4
        [When(@"user clicks Review button")]
        public void WhenUserClicksReviewButton()
        {
            DriverHolder.driver.FindElement(By.XPath("//a[contains(text(),'Reviews (0)')]")).Click();
        }

        [When(@"types his commentary '([^']*)' in relevant field")]
        public void WhenTypesHisCommentaryInRelevantField(string adff)
        {
            DriverHolder.driver.FindElement(By.XPath("//textarea[@id='comment']")).SendKeys(adff);
        }

        [When(@"evaluates a rating of the book")]
        public void WhenEvaluatesARatingOfTheBook()
        {
            DriverHolder.driver.FindElement(By.XPath("//form[@id='commentform']/p[2]/p/span/a[5]")).Click();

        }

        [When(@"adds his name '([^']*)'")]
        public void WhenAddsHisName(string petya)
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@id='author']")).SendKeys(petya);
        }

        [When(@"writes his email '([^']*)'")]
        public void WhenWritesHisEmail(string p0)
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@id='email']")).SendKeys(p0);
        }

        [When(@"clicks button Submit")]
        public void WhenClicksButtonSubmit()
        {
            DriverHolder.driver.FindElement(By.XPath("//input[@id='submit']")).Click();
        }

        [Then(@"user can see a message that '([^']*)'")]
        public void ThenUserCanSeeAMessageThat(string p0)
        {
            IWebElement element = DriverHolder.driver.FindElement(By.XPath("//p[contains(.,'Duplicate comment detected; it looks as though you’ve already said that!')]"));
            string actual = element.Text;
            Assert.Equal(p0, actual);
            DriverHolder.driver.Quit();
        }

        
    }
}
