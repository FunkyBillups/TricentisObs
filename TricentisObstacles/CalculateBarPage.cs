using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TricentisObstacles
{
	class CalculateBarPage
	{
		public CalculateBarPage()
		{
			PageFactory.InitElements(PropertiesCollection.driver, this);
		}

		[FindsBy(How = How.Id, Using = "one")]
		public IWebElement calculateBtn { get; set; }

		[FindsBy(How = How.XPath, Using = "//*[@id=\"label\"]")]
		public IWebElement bar { get; set; }

		[FindsBy(How = How.Id, Using = "two")]
		public IWebElement sendBtn { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/div[7]/button[1]")]
		public IWebElement ClosePopUp { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/h2")]
		public IWebElement Completed { get; set; }

		public void test()
		{
			calculateBtn.Click();
			WebDriverWait waitForElement = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(50));
			waitForElement.Until(ExpectedConditions.ElementToBeClickable(By.Id("two")));
			Thread.Sleep(500);
			sendBtn.Click();
			Thread.Sleep(800);
			Assert.IsTrue(Completed.Text.Contains("Good job"), "Not Completed");
			ClosePopUp.Click();
		}
	}
}
