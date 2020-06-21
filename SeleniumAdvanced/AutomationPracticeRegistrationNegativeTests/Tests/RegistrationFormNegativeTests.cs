using AutoFixture;
using NUnit.Framework;

namespace SeleniumAdvanced.AutomationPracticeRegistrationNegativeTests.Tests
{
    using Factories;
    using Pages;

    [TestFixture]
    public class RegistrationFormNegativeTests : BaseTest
    {
        private AutomationPracticeRegistration _registrationForm;

        [OneTimeSetUp]
        public void TestsSetup()
        {
            var validEmail = this.Fixture.Create<string>().Substring(0, 16) + "@email.com";
            this._registrationForm = new AutomationPracticeHome(this.Driver)
                .GoToEmailForm()
                .FillEmailFormWithValidEmail(validEmail)
                .GoToRegistrationPage();
        }

        [TestCase("PostCode", "", "The Zip/Postal code you've entered is invalid. It must follow this format: 00000")]
        [TestCase("PostCode", "1234", "The Zip/Postal code you've entered is invalid. It must follow this format: 00000")]
        [TestCase("PostCode", "1234567890123", "postcode is too long. Maximum length: 12")]
        [TestCase("FirstName", "", "firstname is required.")]
        [TestCase("FirstName", "6F88E86D-A9D6-4A91-873A-06357C616B18", "firstname is invalid.")]
        [TestCase("LastName", "", "lastname is required.")]
        [TestCase("LastName", "6F88E86D-A9D6-4A91-873A-06357C616B18", "lastname is invalid.")]
        [TestCase("Password", "", "passwd is required.")]
        [TestCase("Password", "1", "passwd is invalid.")]
        [TestCase("City", "", "city is required.")]
        [TestCase("Phone", "", "You must register at least one phone number.")]
        [TestCase("Phone", "6F88E86D-A9D6-4A91-873A-06357C616B18", "phone_mobile is invalid.")]
        [TestCase("Address", "", "address1 is required.")]
        public void FormSubmissionMustProvideCorrectErrorMessage_When_InvalidFieldValueIsSubmitted(string testedField, string testedValue, string expectedErrorMessage)
        {

            var model = RegistrationFormFactory.Create(this.Fixture);
            
            model.GetType().GetProperty(testedField)?.SetValue(model, testedValue);

            var actualErrorMessage = this._registrationForm
                .FillWith(model)
                .Submit()
                .GetErrorMessage();

            Assert.AreEqual(expectedErrorMessage, actualErrorMessage);

        }
    }
}