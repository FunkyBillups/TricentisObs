using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TricentisObstacles
{
	class GetMethods
	{
		public static string GetTextValue(IWebElement element)
		{
			return element.GetAttribute("value");
		}

		public static string GetTextTask(IWebElement element)
		{
			return element.GetAttribute("task");
		}

		public static string GetTextFromDDL(IWebElement element)
		{
			return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
		}
	}
}
