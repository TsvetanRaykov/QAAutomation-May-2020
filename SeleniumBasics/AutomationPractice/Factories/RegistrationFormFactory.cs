namespace SeleniumBasics.AutomationPractice.Factories
{
    using SeleniumBasics.AutomationPractice.Models;

    public static class RegistrationFormFactory
    {
        public static Subscriber Create()
        {
            return new Subscriber
            {
                Email = "pdndtdabisovxvhoae@awdrt.net"
            };
        }
    }
}
