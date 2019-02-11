using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace TricentisObstacles
{
	class ExtractTextPage
	{
		public ExtractTextPage()
		{
			PageFactory.InitElements(PropertiesCollection.driver, this);
		}

		[FindsBy(How = How.Id, Using = "alerttext")]
		public IWebElement alertText { get; set; }

		[FindsBy(How = How.Id, Using = "totalamountText")]
		public IWebElement enterAmount { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/div[7]/button[1]")]
		public IWebElement ClosePopUp { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/h2")]
		public IWebElement Completed { get; set; }

		public void test()
		{
			Regex regex = new Regex(@"\d+\.*\d*");
			string text = alertText.Text;
			Match match = regex.Match(text);
			if (match.Success) 
				SetMethods.EnterText(enterAmount, match.Value);
			Thread.Sleep(800);
			Assert.IsTrue(Completed.Text.Contains("Good job"), "Not Completed");
			ClosePopUp.Click();
		}
	}
}
