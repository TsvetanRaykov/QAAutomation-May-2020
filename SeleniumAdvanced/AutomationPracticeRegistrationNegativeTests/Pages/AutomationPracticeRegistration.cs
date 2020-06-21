namespace SeleniumAdvanced.AutomationPracticeRegistrationNegativeTests.Pages
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;
    using TestUtils.Decorators;
    using Models;

    public class AutomationPracticeRegistration : BasePage
    {
        public AutomationPracticeRegistration(WebDriver driver) : base(driver)
        {
        }

        private Element FirstName => this.Driver.FindElement(By.Id("customer_firstname"));

        private Element LastName => this.Driver.FindElement(By.Id("customer_lastname"));

        private Element Password => this.Driver.FindElement(By.Id("passwd"));

        private Element City => this.Driver.FindElement(By.Id("city"));

        private Element PostCode => this.Driver.FindElement(By.Id("postcode"));

        private Element Phone => this.Driver.FindElement(By.Id("phone_mobile"));

        private Element Address => this.Driver.FindElement(By.Id("address1"));

        private Element SubmitButton => this.Driver.FindElement(By.Id("submitAccount"));

        private WebElement StateDropDown => this.Driver.FindElement(By.Id("id_state")) as WebElement;

        private Element ErrorContainer => this.Driver.FindElement(By.XPath("//div[contains(@class,'alert-danger')]//li"));

        public AutomationPracticeRegistration FillWith(RegisterFormModel model)
        {
            this.FirstName.TypeText(model.FirstName);
            this.LastName.TypeText(model.LastName);
            this.Password.TypeText(model.Password);
            this.City.TypeText(model.City);
            this.PostCode.TypeText(model.PostCode);
            this.Phone.TypeText(model.Phone);
            this.Address.TypeText(model.Address);

            var stateDropdown = new SelectElement(this.StateDropDown.NativeElement);
            stateDropdown.SelectByIndex(1);

            return this;
        }

        public AutomationPracticeRegistration Submit()
        {
            this.SubmitButton.Click();
            return this;
        }

        public string GetErrorMessage()
        {
            return this.ErrorContainer.Text;
        }
    }
}