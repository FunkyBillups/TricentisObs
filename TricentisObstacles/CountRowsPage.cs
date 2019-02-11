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
	class CountRowsPage
	{
		public CountRowsPage()
		{
			PageFactory.InitElements(PropertiesCollection.driver, this);
		}

		[FindsBy(How = How.Id, Using = "rowcount")]
		public IWebElement rowCount { get; set; }

		[FindsBy(How = How.Id, Using = "sample")]
		public IWebElement DoneBtn { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/div[7]/button[1]")]
		public IWebElement ClosePopUp { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/h2")]
		public IWebElement Completed { get; set; }

		public void test()
		{
			int count = 1;
			try
			{
				while (count < 100)
				{
					IWebElement row = PropertiesCollection.driver.FindElement(By.XPath("//*[@id=\"rowCountTable\"]/tbody/tr[" + count + "]"));
					count++;
				}
			}
			catch (NoSuchElementException e)
			{
				count = count - 1;
			}
			SetMethods.EnterText(rowCount, "" + count);
			DoneBtn.Click();
			Thread.Sleep(800);
			Assert.IsTrue(Completed.Text.Contains("Good job"), "Not Completed");
			ClosePopUp.Click();
		}
	}
}
