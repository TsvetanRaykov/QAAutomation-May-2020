﻿namespace SeleniumBasics.AutomationPractice.Tests
{
    using NUnit.Framework;
    using SeleniumBasics.AutomationPractice.Factories;
    using SeleniumBasics.AutomationPractice.Pages;

    [TestFixture]
    public class AutomationPracticeTests : BaseTest
    {
        [Test]
        public void SameEmailIsSetToEmailFieldInRegistrationForm()
        {

            var user = RegistrationFormFactory.Create();

            var run = new AutomationPracticePage(this.Driver);

            var actualEmailInFormAfterSubmit = run.GoToAutomationPracticePage()
                .GoToLoginPage()
                .FillRegistrationForm(user)
                .GetEmailFieldValue();

            Assert.AreEqual(user.Email, actualEmailInFormAfterSubmit);

        }
    }
}