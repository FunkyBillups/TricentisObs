using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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
	class ToughCookiePage
	{
		public ToughCookiePage()
		{
			PageFactory.InitElements(PropertiesCollection.driver, this);
		}

		[FindsBy(How = How.Id, Using = "generated")]
		public IWebElement generateTXT { get; set; }

		[FindsBy(How = How.Id, Using = "firstNumber")]
		public IWebElement firstNum { get; set; }

		[FindsBy(How = How.Id, Using = "secondNumber")]
		public IWebElement secNum { get; set; }

		[FindsBy(How = How.Id, Using = "thirdNumber")]
		public IWebElement thirdNum { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/div[7]/button[1]")]
		public IWebElement ClosePopUp { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/h2")]
		public IWebElement Completed { get; set; }

		public void test()
		{
			generateTXT.Click();
			string text = GetMethods.GetTextValue(generateTXT);
			Console.WriteLine(text);
			Regex regex = new Regex(@"\d+");
			Match match = regex.Match(text);
			if (match.Success)
				SetMethods.EnterText(firstNum, match.Value);
			match = match.NextMatch();
			if (match.Success)
				SetMethods.EnterText(secNum, match.Value);
			match = match.NextMatch();
			if (match.Success)
				SetMethods.EnterText(thirdNum, match.Value);
			firstNum.Click();
			Thread.Sleep(800);
			Assert.IsTrue(Completed.Text.Contains("Good job"), "Not Completed");
			ClosePopUp.Click();
		}
	}
}
