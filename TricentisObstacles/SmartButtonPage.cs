﻿using NUnit.Framework;
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
	class SmartButtonPage
	{
		public SmartButtonPage()
		{
			PageFactory.InitElements(PropertiesCollection.driver, this);
		}

		[FindsBy(How = How.Id, Using = "changeIdButton")]
		public IWebElement ClickMeFirst { get; set; }

		[FindsBy(How = How.Id, Using = "myLink_new")]
		public IWebElement ClickMeThen { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/div[7]/button[1]")]
		public IWebElement ClosePopUp { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/h2")]
		public IWebElement Completed { get; set; }

		public void test()
		{
			ClickMeFirst.Click();
			ClickMeThen.Click();
			Thread.Sleep(800);
			Assert.IsTrue(Completed.Text.Contains("Good job"), "Not Completed");
			ClosePopUp.Click();
		}
	}
}
