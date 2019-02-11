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
	class AdditionPage
	{
		public AdditionPage()
		{
			PageFactory.InitElements(PropertiesCollection.driver, this);
		}

		[FindsBy(How = How.Id, Using = "no1")]
		public IWebElement firstInt { get; set; }

		[FindsBy(How = How.Id, Using = "no2")]
		public IWebElement secInt { get; set; }

		[FindsBy(How = How.Id, Using = "result")]
		public IWebElement result { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/div[7]/button[1]")]
		public IWebElement ClosePopUp { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/h2")]
		public IWebElement Completed { get; set; }

		public void test()
		{
			string total = Convert.ToInt32(firstInt.Text) + Convert.ToInt32(secInt.Text) + "";
			SetMethods.EnterText(result, total);
			Thread.Sleep(800);
			Assert.IsTrue(Completed.Text.Contains("Good job"), "Not Completed");
			ClosePopUp.Click();
		}
	}
}
