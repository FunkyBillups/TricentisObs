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
	class MovingButtonPage
	{
		public MovingButtonPage()
		{
			PageFactory.InitElements(PropertiesCollection.driver, this);
		}

		[FindsBy(How = How.Id, Using = "buttontoclick")]
		public IWebElement Button { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/div[7]/button[1]")]
		public IWebElement ClosePopUp { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/h2")]
		public IWebElement Completed { get; set; }

		public void test()
		{
			Button.SendKeys(Keys.Enter);
			Thread.Sleep(800);
			Assert.IsTrue(Completed.Text.Contains("Good job"), "Not Completed");
			ClosePopUp.Click();
		}
	}
}
