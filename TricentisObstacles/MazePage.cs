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
	class MazePage
	{
		public MazePage()
		{
			PageFactory.InitElements(PropertiesCollection.driver, this);
		}

		[FindsBy(How = How.Id, Using = "generate")]
		public IWebElement GenerateBtn { get; set; }

		[FindsBy(How = How.Id, Using = "checkpoint0")]
		public IWebElement Cp1 { get; set; }

		[FindsBy(How = How.Id, Using = "checkpoint1")]
		public IWebElement Cp2 { get; set; }

		[FindsBy(How = How.Id, Using = "checkpoint2")]
		public IWebElement Cp3 { get; set; }

		[FindsBy(How = How.Id, Using = "checkpoint3")]
		public IWebElement Cp4 { get; set; }

		[FindsBy(How = How.Id, Using = "checkpoint4")]
		public IWebElement Cp5 { get; set; }

		[FindsBy(How = How.Id, Using = "checkpoint5")]
		public IWebElement Cp6 { get; set; }

		[FindsBy(How = How.Id, Using = "checkpoint6")]
		public IWebElement Cp7 { get; set; }

		[FindsBy(How = How.Id, Using = "checkpoint7")]
		public IWebElement Cp8 { get; set; }

		[FindsBy(How = How.Id, Using = "checkpoint8")]
		public IWebElement Cp9 { get; set; }

		[FindsBy(How = How.Id, Using = "checkpoint9")]
		public IWebElement Cp10 { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/div[7]/button[1]")]
		public IWebElement ClosePopUp { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/h2")]
		public IWebElement Completed { get; set; }

		public void test()
		{
			GenerateBtn.Click();
			Cp1.Click();
			Cp2.Click();
			Cp3.Click();
			Cp4.Click();
			Cp5.Click();
			Cp6.Click();
			Cp7.Click();
			Cp8.Click();
			Cp9.Click();
			Cp10.Click();
			Thread.Sleep(800);
			Assert.IsTrue(Completed.Text.Contains("Good job"), "Not Completed");
			ClosePopUp.Click();
		}
	}
}
