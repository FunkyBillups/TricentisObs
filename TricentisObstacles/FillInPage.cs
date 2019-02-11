using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TricentisObstacles
{
	class FillInPage
	{
		public FillInPage()
		{
			PageFactory.InitElements(PropertiesCollection.driver, this);
		}

		[FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[1]/div[1]/div[2]/div/div[2]/input[1]")]
		public IWebElement UserName { get; set; }

		[FindsBy(How = How.Id, Using = "pass")]
		public IWebElement Password { get; set; }

		[FindsBy(How = How.Id, Using = "actual")]
		public IWebElement PasswordA { get; set; }

		[FindsBy(How = How.Id, Using = "sample")]
		public IWebElement ClickMe { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/div[7]/button[1]")]
		public IWebElement ClosePopUp { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/h2")]
		public IWebElement Completed { get; set; }

		public void test()
		{
			Password.Click();
			PasswordA.Click();
			SetMethods.EnterText(PasswordA, "ABC");
			ClickMe.Click();
			Thread.Sleep(800);
			Assert.IsTrue(Completed.Text.Contains("Good job"), "Not Completed");
			ClosePopUp.Click();
		}
	}
}
