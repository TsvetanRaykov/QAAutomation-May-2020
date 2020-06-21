using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumBasics.SoftUni
{
    public class QaCoursePage : BasePage
    {
        public QaCoursePage(IWebDriver driver) : base(driver) { }

        [CacheLookup, FindsBy(How = How.TagName, Using = "h1")]
        private IList<IWebElement> _headings;

        /// <summary>
        /// Retrieve the headings as Base64 strings in order to avoid failures caused by encoding.
        /// E.g. QA Automation - ìàé 2020 
        /// </summary>
        public string[] GetHeadingsAsBase64()
        {
            return this._headings?
                .Select(a =>
                {
                    var strBytes = Encoding.UTF8.GetBytes(a.Text);
                    return Convert.ToBase64String(strBytes);
                })
                .ToArray() ?? new string[0];
        }

        public string[] GetHeadings()
        {
            return this._headings?
                .Select(a => a.Text)
                .ToArray() ?? new string[0];
        }

    }
}