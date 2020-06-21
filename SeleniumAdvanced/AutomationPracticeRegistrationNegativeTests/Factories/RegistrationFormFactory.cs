using AutoFixture;

namespace SeleniumAdvanced.AutomationPracticeRegistrationNegativeTests.Factories
{
    using Models;
    using TestUtils.Extensions;

    public static class RegistrationFormFactory
    {
        public static RegisterFormModel Create(IFixture fixture)
        {
            return fixture.Build<RegisterFormModel>()
                .With(x => x.Phone, fixture.CreateInt(100000, 999999).ToString())
                .With(x => x.PostCode, fixture.CreateInt(10000, 99999).ToString())
                .With(x=>x.FirstName, fixture.CreateRandomString(8))
                .With(x=>x.LastName, fixture.CreateRandomString(8))
                .Create();
        }
    }
}