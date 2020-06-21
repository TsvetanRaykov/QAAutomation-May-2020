namespace SeleniumAdvanced.Interactions.Pages
{
    using NUnit.Framework;

    public partial class DemoQa
    {
        public void AssertThatSectionExist(string sectionName)
        {
            this.NavigateToSection(sectionName);

            Assert.AreEqual(sectionName, this.SectionHeader.Text.Trim());
        }
    }
}