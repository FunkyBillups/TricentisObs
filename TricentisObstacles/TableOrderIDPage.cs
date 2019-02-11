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
	class TableOrderIDPage
	{
		public TableOrderIDPage()
		{
			PageFactory.InitElements(PropertiesCollection.driver, this);
		}
		[FindsBy(How = How.Id, Using = "generate")]
		public IWebElement generateBtn { get; set; }

		[FindsBy(How = How.Id, Using = "offerId")]
		public IWebElement enterID { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/div[7]/button[1]")]
		public IWebElement ClosePopUp { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/h2")]
		public IWebElement Completed { get; set; }

		public void test()
		{
			generateBtn.Click();
			string number;
			for (int i = 1; i < 13; i++)
			{
				IWebElement column1 = PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[2]/div[1]/div[1]/div[2]/div/div[2]/div[2]/div[" + i + "]/div[1]"));
				string name = column1.Text;
				if (name.Equals("order id"))
				{
					IWebElement column2 = PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[2]/div[1]/div[1]/div[2]/div/div[2]/div[2]/div[" + i + "]/div[2]"));
					number = column2.Text;
					SetMethods.EnterText(enterID, number);
				}
			}
			Thread.Sleep(800);
			Assert.IsTrue(Completed.Text.Contains("Good job"), "Not Completed");
			ClosePopUp.Click();
		}
	}
}