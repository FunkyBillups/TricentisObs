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
	class ConfusingDatesPage
	{
		public ConfusingDatesPage()
		{
			PageFactory.InitElements(PropertiesCollection.driver, this);
		}

		[FindsBy(How = How.Id, Using = "generate")]
		public IWebElement generate { get; set; }

		[FindsBy(How = How.Id, Using = "dateGenerated")]
		public IWebElement dateGenerated { get; set; }

		[FindsBy(How = How.Id, Using = "dateSolution")]
		public IWebElement dateSolution { get; set; }

		[FindsBy(How = How.Id, Using = "done")]
		public IWebElement done { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/div[7]/button[1]")]
		public IWebElement ClosePopUp { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/h2")]
		public IWebElement Completed { get; set; }

		public void test()
		{
			generate.Click();
			Regex year1 = new Regex(@"\d{4}");
			Regex monthDay = new Regex(@"\d{1,2}");
			string date1 = GetMethods.GetTextValue(dateGenerated);
			string date2, finalDate = "";

			Match match = monthDay.Match(date1);
			if (match.Success)
			{
				if (Convert.ToInt32(match.Value) == 11)
				{
					date2 = "-01-01";
					match = year1.Match(date1);
					finalDate = (Convert.ToInt32(match.Value) + 1) + date2;
				}
				if (Convert.ToInt32(match.Value) == 12)
				{
					date2 = "-02-01";
					match = year1.Match(date1);
					finalDate = (Convert.ToInt32(match.Value) + 1) + date2;
				}
				else
				{
					if ((Convert.ToInt32(match.Value) + 2 + "").Length == 1)
					{
						date2 = "-0" + (Convert.ToInt32(match.Value) + 2) + "-01";
					}
					else
					{
						date2 = "-" + (Convert.ToInt32(match.Value) + 2) + "-01";
					}
					match = year1.Match(date1);
					finalDate = Convert.ToInt32(match.Value) + date2;
				}
			}
			SetMethods.EnterText(dateSolution, finalDate);
			done.Click();
			Thread.Sleep(800);
			Assert.IsTrue(Completed.Text.Contains("Good job"), "Not Completed");
			ClosePopUp.Click();
		}
	}
}
