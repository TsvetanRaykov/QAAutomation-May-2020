using SeleniumBasics.AutomationPractice.Models;

namespace SeleniumBasics.AutomationPractice.Factories
{
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
