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
	class MathsPage
	{
		public MathsPage()
		{
			PageFactory.InitElements(PropertiesCollection.driver, this);
		}

		[FindsBy(How = How.Id, Using = "no1")]
		public IWebElement firstInt { get; set; }

		[FindsBy(How = How.Id, Using = "no2")]
		public IWebElement secInt { get; set; }

		[FindsBy(How = How.Id, Using = "symbol1")]
		public IWebElement symbol { get; set; }

		[FindsBy(How = How.Id, Using = "result")]
		public IWebElement result { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/div[7]/button[1]")]
		public IWebElement ClosePopUp { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/h2")]
		public IWebElement Completed { get; set; }

		public void test()
		{
			int num1 = Convert.ToInt32(firstInt.Text);
			int num2 = Convert.ToInt32(secInt.Text);
			char op = Convert.ToChar(symbol.Text);
			Console.WriteLine(op);
			string sum = "" + operation(num1, num2, op);
			SetMethods.EnterText(result, sum);
			Thread.Sleep(800);
			Assert.IsTrue(Completed.Text.Contains("Good job"), "Not Completed");
			ClosePopUp.Click();
		}
		private int operation (int x, int y, char op)
		{
			switch (op)
			{
				case '+':
					return x + y;
				case '-':
					return x - y;
				case '/':
					return x / y;
				case '*':
					return x * y;
				case '%':
					return x % y;
				default:
					return 0;
			}
		}
	}
}
