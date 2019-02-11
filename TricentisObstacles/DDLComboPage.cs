using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TricentisObstacles
{
	class DDLComboPage
	{
		public DDLComboPage()
		{
			PageFactory.InitElements(PropertiesCollection.driver, this);
		}

		[FindsBy(How = How.Id, Using = "clickme")]
		public IWebElement ClickMe { get; set; }

		[FindsBy(How = How.Id, Using = "randomtext")]
		public IWebElement GenerateText { get; set; }

		[FindsBy(How = How.Id, Using = "selectlink")]
		public IWebElement ddl { get; set; }

		[FindsBy(How = How.Id, Using = "submitanswer")]
		public IWebElement Submit { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/div[7]/button[1]")]
		public IWebElement ClosePopUp { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/h2")]
		public IWebElement Completed { get; set; }

		public void test()
		{
			ClickMe.Click();
			string text = GetMethods.GetTextValue(GenerateText);
			SelectElement selectList = new SelectElement(ddl);
			IList<IWebElement> options = selectList.Options;
			for (int j = 2; j < options.Count; j++)
			{
				string optionText = options[j].Text.ToString();
				Console.WriteLine("{0} : {1}", text, optionText);
				if (text.Equals(optionText))
				{
					SetMethods.SelectDropDown(ddl, optionText);
					break;
				}
			}
			Submit.Click();
			Thread.Sleep(800);
			Assert.IsTrue(Completed.Text.Contains("Good job"), "Not Completed");
			ClosePopUp.Click();
		}
	}
}
