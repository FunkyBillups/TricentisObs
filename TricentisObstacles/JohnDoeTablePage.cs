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
	class JohnDoeTablePage
	{
		public JohnDoeTablePage()
		{
			PageFactory.InitElements(PropertiesCollection.driver, this);
		}

		[FindsBy(How = How.XPath, Using = "//*[@id=\"persons\"]/tbody/tr[1]/td[1]")]
		public IWebElement FN1 { get; set; }

		[FindsBy(How = How.XPath, Using = "//*[@id=\"persons\"]/tbody/tr[2]/td[1]")]
		public IWebElement FN2 { get; set; }

		[FindsBy(How = How.XPath, Using = "//*[@id=\"persons\"]/tbody/tr[3]/td[1]")]
		public IWebElement FN3 { get; set; }

		[FindsBy(How = How.XPath, Using = "//*[@id=\"persons\"]/tbody/tr[4]/td[1]")]
		public IWebElement FN4 { get; set; }

		[FindsBy(How = How.XPath, Using = "//*[@id=\"persons\"]/tbody/tr[1]/td[2]")]
		public IWebElement LN1 { get; set; }

		[FindsBy(How = How.XPath, Using = "//*[@id=\"persons\"]/tbody/tr[2]/td[2]")]
		public IWebElement LN2 { get; set; }

		[FindsBy(How = How.XPath, Using = "//*[@id=\"persons\"]/tbody/tr[3]/td[2]")]
		public IWebElement LN3 { get; set; }

		[FindsBy(How = How.XPath, Using = "//*[@id=\"persons\"]/tbody/tr[4]/td[2]")]
		public IWebElement LN4 { get; set; }

		[FindsBy(How = How.XPath, Using = "//*[@id=\"persons\"]/tbody/tr[1]/td[4]/div/button[2]")]
		public IWebElement editBtn1 { get; set; }

		[FindsBy(How = How.XPath, Using = "//*[@id=\"persons\"]/tbody/tr[2]/td[4]/div/button[2]")]
		public IWebElement editBtn2 { get; set; }

		[FindsBy(How = How.XPath, Using = "//*[@id=\"persons\"]/tbody/tr[3]/td[4]/div/button[2]")]
		public IWebElement editBtn3 { get; set; }

		[FindsBy(How = How.XPath, Using = "//*[@id=\"persons\"]/tbody/tr[4]/td[4]/div/button[2]")]
		public IWebElement editBtn4 { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/div[7]/button[1]")]
		public IWebElement ClosePopUp { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/h2")]
		public IWebElement Completed { get; set; }

		public void test()
		{
			if (FN1.Text.Equals("John") && LN1.Text.Equals("Doe"))
				editBtn1.Click();
			if (FN2.Text.Equals("John") && LN2.Text.Equals("Doe"))
				editBtn2.Click();
			if (FN3.Text.Equals("John") && LN3.Text.Equals("Doe"))
				editBtn3.Click();
			if (FN4.Text.Equals("John") && LN4.Text.Equals("Doe"))
				editBtn4.Click();
			Thread.Sleep(800);
			Assert.IsTrue(Completed.Text.Contains("Good job"), "Not Completed");
			ClosePopUp.Click();
		}
	}
}
