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
	class TomorrowDatePage
	{
		public TomorrowDatePage()
		{
			PageFactory.InitElements(PropertiesCollection.driver, this);
		}

		[FindsBy(How = How.Id, Using = "datefield")]
		public IWebElement dateBox { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/div[7]/button[1]")]
		public IWebElement ClosePopUp { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/h2")]
		public IWebElement Completed { get; set; }

		public void test()
		{
			DateTime tomorrow = DateTime.Now.AddDays(1);
			string date = tomorrow.ToString("d");
			string finalDate = "";
			Regex dayMonth = new Regex(@"\d{1,2}");
			Regex year = new Regex(@"\d{4}");
			Match match = dayMonth.Match(date);
			if (match.Success)
			{
				finalDate = finalDate + match.Value + ".";
			}
			match = match.NextMatch();
			if (match.Success)
			{
				finalDate = finalDate + match.Value + ".";
			}
			match = year.Match(date);
			if (match.Success)
			{
				finalDate = finalDate + match.Value;
			}
			SetMethods.EnterText(dateBox, finalDate);
			Thread.Sleep(800);
			Assert.IsTrue(Completed.Text.Contains("Good job"), "Not Completed");
			ClosePopUp.Click();
		}
	}
}