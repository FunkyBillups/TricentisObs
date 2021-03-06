﻿using NUnit.Framework;
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
	class MultiSelectPage
	{
		public MultiSelectPage()
		{
			PageFactory.InitElements(PropertiesCollection.driver, this);
		}

		[FindsBy(How = How.XPath, Using = "//*[@id=\"multiselect\"]/option[1]")]
		public IWebElement selFunctional { get; set; }

		[FindsBy(How = How.XPath, Using = "//*[@id=\"multiselect\"]/option[3]")]
		public IWebElement selGUI { get; set; }

		[FindsBy(How = How.XPath, Using = "//*[@id=\"multiselect\"]/option[4]")]
		public IWebElement selE2E { get; set; }

		[FindsBy(How = How.XPath, Using = "//*[@id=\"multiselect\"]/option[5]")]
		public IWebElement selExp { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/div[7]/button[1]")]
		public IWebElement ClosePopUp { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/h2")]
		public IWebElement Completed { get; set; }

		public void test()
		{
			Actions actions = new Actions(PropertiesCollection.driver);
			actions.KeyDown(Keys.LeftControl).Click(selFunctional).Click(selGUI).Click(selE2E).Click(selExp).KeyUp(Keys.LeftControl).Build().Perform();
			Thread.Sleep(800);
			Assert.IsTrue(Completed.Text.Contains("Good job"), "Not Completed");
			ClosePopUp.Click();
		}
	}
}
