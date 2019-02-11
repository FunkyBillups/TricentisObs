using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TricentisObstacles
{
	class CountEntriesPage
	{
		public CountEntriesPage()
		{
			PageFactory.InitElements(PropertiesCollection.driver, this);
		}

		[FindsBy(How = How.XPath, Using = "//*[@id=\"typeThis\"]")]
		public IWebElement letters { get; set; }

		[FindsBy(How = How.Id, Using = "entryCount")]
		public IWebElement enterCount { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/div[7]/button[1]")]
		public IWebElement ClosePopUp { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/h2")]
		public IWebElement Completed { get; set; }

		public void test()
		{
			if (letters.Text.Equals("AAA"))
				SetMethods.EnterText(enterCount, "3");
			if (letters.Text.Equals("BBB"))
				SetMethods.EnterText(enterCount, "4");
			if (letters.Text.Equals("CCC"))
				SetMethods.EnterText(enterCount, "2");
			if (letters.Text.Equals("DDD"))
				SetMethods.EnterText(enterCount, "5");
			if (letters.Text.Equals("EEE"))
				SetMethods.EnterText(enterCount, "1");
			Thread.Sleep(800);
			Assert.IsTrue(Completed.Text.Contains("Good job"), "Not Completed");
			ClosePopUp.Click();
		}
	}
}
