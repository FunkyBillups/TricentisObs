using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace TricentisObstacles
{
	class ChristmasDayPage
	{
		public ChristmasDayPage()
		{
			PageFactory.InitElements(PropertiesCollection.driver, this);
		}

		[FindsBy(How = How.Id, Using = "christmasday")]
		public IWebElement EnterDay { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/div[7]/button[1]")]
		public IWebElement ClosePopUp { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/h2")]
		public IWebElement Completed { get; set; }

		public void test()
		{
			// Add 2 years to current date
			DateTime christmasDay = DateTime.Now.AddYears(2);
			int month = christmasDay.Month;
			int day = christmasDay.Day;

			// Find number of months to add to current month
			christmasDay = christmasDay.AddMonths(12 - month);

			// Find number of days to add or subtract from current day
			if (day > 25)
			{
				christmasDay = christmasDay.AddDays(-(day - 25));
			}
			else
			{
				christmasDay = christmasDay.AddDays(25 - day);
			}
			SetMethods.EnterText(EnterDay, "" + christmasDay.DayOfWeek);
			Thread.Sleep(800);
			Assert.IsTrue(Completed.Text.Contains("Good job"), "Not Completed");
			ClosePopUp.Click();
		}
	}
}
