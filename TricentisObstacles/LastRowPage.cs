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
	class LastRowPage
	{
		public LastRowPage()
		{
			PageFactory.InitElements(PropertiesCollection.driver, this);
		}

		[FindsBy(How = How.Id, Using = "ordervalue")]
		public IWebElement orderBox { get; set; }

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
					IWebElement row = PropertiesCollection.driver.FindElement(By.XPath("//*[@id=\"orderTable\"]/tbody/tr[" + count + "]"));
					count++;
				}
			}
			catch (NoSuchElementException e)
			{
				count = count - 1;
			}
			IWebElement lastRow = PropertiesCollection.driver.FindElement(By.XPath("//*[@id=\"orderTable\"]/tbody/tr[" + count + "]/td[2]"));
			SetMethods.EnterText(orderBox, lastRow.Text);
			Thread.Sleep(800);
			Assert.IsTrue(Completed.Text.Contains("Good job"), "Not Completed");
			ClosePopUp.Click();
		}
	}
}
