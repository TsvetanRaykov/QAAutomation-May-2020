namespace SeleniumAdvanced.Interactions.Pages.Selectable
{
    using System.Linq;
    using NUnit.Framework;

    public partial class SelectablePage : DemoQa
    {
     
        public void AssertThatSelectedItemHaveCorrectClass()
        {
            foreach (var listItem in this.ListItems)
            {
                listItem.NativeElement.Click();
            }

            Assert.IsTrue(this.ListItems.All(e => e.GetAttribute("class").Contains("active")));
        }

        public void AssertThatSelectedItemMustDifferentColor()
        {
            foreach (var testBox in this.TestBoxes)
            {
                var colorBefore = testBox.GetCssValue("background-color");
                testBox.NativeElement.Click();
                var colorAfter = testBox.GetCssValue("background-color");

                Assert.That(colorAfter, Is.Not.EqualTo(colorBefore));
            }
        }

    }
}