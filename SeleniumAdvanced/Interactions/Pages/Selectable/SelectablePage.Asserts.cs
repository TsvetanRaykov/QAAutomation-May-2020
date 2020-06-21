using System.Linq;
using NUnit.Framework;

namespace SeleniumAdvanced.Interactions.Pages.Selectable
{
    public partial class SelectablePage : DemoQa
    {
     
        public void AssertThatSelectedItemHaveCorrectClass()
        {
            foreach (var listItem in this._listItems)
            {
                listItem.Click();
            }

            Assert.IsTrue(this._listItems.All(e => e.GetAttribute("class").Contains("active")));
        }

        public void AssertThatSelectedItemMustDifferentColor()
        {
            foreach (var testBox in this._testBoxes)
            {
                var colorBefore = testBox.GetCssValue("background-color");
                testBox.Click();
                var colorAfter = testBox.GetCssValue("background-color");

                Assert.That(colorAfter, Is.Not.EqualTo(colorBefore));
            }
        }

    }
}