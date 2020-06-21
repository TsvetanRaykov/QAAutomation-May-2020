using NUnit.Framework;

namespace SeleniumAdvanced.Interactions.Pages
{
    public partial class DemoQa
    {
        public void AssertThatSectionExist(string sectionName)
        {
            this.NavigateToSection(sectionName);

            Assert.AreEqual(sectionName, this._sectionHeader.Text.Trim());
        }
    }
}