using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TricentisObstacles
{
	class SetMethods
	{
		//Enter Text
		public static void EnterText(IWebElement element, string value)
		{
			element.SendKeys(value);
		}

		//Click 
		public static void Click(IWebElement element)
		{
			element.Click();
		}

		//Select a drop down control
		public static void SelectDropDown(IWebElement element, string value)
		{
			new SelectElement(element).SelectByText(value);
		}

		//Waits for an element to appear
		public static void WaitUntil(string xpath, int time)
		{
			WebDriverWait waitForElement = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(time));
			waitForElement.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
		}
	}
}
