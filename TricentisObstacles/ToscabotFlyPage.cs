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
	class ToscabotFlyPage
	{
		public ToscabotFlyPage()
		{
			PageFactory.InitElements(PropertiesCollection.driver, this);
		}

		[FindsBy(How = How.Id, Using = "toscabot")]
		public IWebElement toscabot { get; set; }

		[FindsBy(How = How.Id, Using = "to")]
		public IWebElement box { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/div[7]/button[1]")]
		public IWebElement ClosePopUp { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/h2")]
		public IWebElement Completed { get; set; }

		public void test()
		{
			// Locate javascript
			string script = System.IO.File.ReadAllText(@"C:\Users\long\Documents\test9.js");
			script += "simulateHTML5DragAndDrop(arguments[0], arguments[1])";

			// Implement javascript to drag and drop
			IJavaScriptExecutor executor = (IJavaScriptExecutor)PropertiesCollection.driver;
			executor.ExecuteScript(script, toscabot, box);

			Thread.Sleep(800);
			Assert.IsTrue(Completed.Text.Contains("Good job"), "Not Completed");
			ClosePopUp.Click();
		}
	}
}
