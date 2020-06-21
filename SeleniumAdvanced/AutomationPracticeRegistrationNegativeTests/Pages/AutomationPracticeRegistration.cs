using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using TestUtils.Extensions;

namespace SeleniumAdvanced.AutomationPracticeRegistrationNegativeTests.Pages
{
    using Models;
    public class AutomationPracticeRegistration : BasePage
    {
        public AutomationPracticeRegistration(IWebDriver driver) : base(driver)
        {
        }

        [CacheLookup, FindsBy(How = How.Id, Using = "customer_firstname")]
        private IWebElement _firstName;

        [CacheLookup, FindsBy(How = How.Id, Using = "customer_lastname")]
        private IWebElement _lastName;

        [CacheLookup, FindsBy(How = How.Id, Using = "passwd")]
        private IWebElement _password;

        [CacheLookup, FindsBy(How = How.Id, Using = "city")]
        private IWebElement _city;

        [CacheLookup, FindsBy(How = How.Id, Using = "postcode")]
        private IWebElement _postCode;

        [CacheLookup, FindsBy(How = How.Id, Using = "phone_mobile")]
        private IWebElement _phone;

        [CacheLookup, FindsBy(How = How.Id, Using = "address1")]
        private IWebElement _address;

        [CacheLookup, FindsBy(How = How.Id, Using = "submitAccount")]
        private IWebElement _submitButton;

        [CacheLookup, FindsBy(How = How.Id, Using = "id_state")]
        private IWebElement _stateDropDown;

        [CacheLookup, FindsBy(How = How.XPath, Using = "//div[contains(@class,'alert-danger')]//li")]
        private IWebElement _errorContainer;

        public AutomationPracticeRegistration FillWith(RegisterFormModel model)
        {
            PageFactory.InitElements(this.Driver, this);

            this._firstName.SetFormInputValue(model.FirstName);
            this._lastName.SetFormInputValue(model.LastName);
            this._password.SetFormInputValue(model.Password);
            this._city.SetFormInputValue(model.City);
            this._postCode.SetFormInputValue(model.PostCode);
            this._phone.SetFormInputValue(model.Phone);
            this._address.SetFormInputValue(model.Address);

            var stateDropdown = new SelectElement(this._stateDropDown);
            stateDropdown.SelectByIndex(1);

            return this;
        }

        public AutomationPracticeRegistration Submit()
        {
            this._submitButton.Click();
            return this;
        }

        public string GetErrorMessage()
        {
            return this._errorContainer.Text;
        }
    }
}