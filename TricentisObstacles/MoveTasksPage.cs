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
	class MoveTasksPage
	{
		public MoveTasksPage()
		{
			PageFactory.InitElements(PropertiesCollection.driver, this);
		}

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/div[7]/button[1]")]
		public IWebElement ClosePopUp { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/h2")]
		public IWebElement Completed { get; set; }

		/*public void test()
		{
			string script = System.IO.File.ReadAllText(@"C:\Users\long\Documents\test9.js");
			script += "simulateHTML5DragAndDrop(arguments[0], arguments[1])";
			IJavaScriptExecutor executor = (IJavaScriptExecutor)PropertiesCollection.driver;
			executor.ExecuteScript(script, toscabot, box);
		}*/

		public void test()
		{
			int order = 1;
			while (order < 7)
			{
				for (int i = 2; i < 8; i++)
				{
					IWebElement start = PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[2]/div[1]/div[1]/div[2]/div/div[2]/div[1]/div/table/tbody/tr[" + i + "]"));
					IWebElement finish = PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[2]/div[1]/div[1]/div[2]/div/div[2]/div[2]/div/table/tbody/tr[1]"));
					string id = GetMethods.GetTextTask(start);
					if (order == Convert.ToInt32(id))
					{
						/*string script = System.IO.File.ReadAllText(@"C:\Users\long\Documents\test9.js");
						script += "simulateHTML5DragAndDrop(arguments[0], arguments[1])";
						IJavaScriptExecutor executor = (IJavaScriptExecutor)PropertiesCollection.driver;
						executor.ExecuteScript(script, start, finish);*/

						Actions action = new Actions(PropertiesCollection.driver);
						action.DragAndDrop(start, finish).Build().Perform();
						order++;
						break;
					}
				}
			}
			Thread.Sleep(800);
			Assert.IsTrue(Completed.Text.Contains("Good job"), "Not Completed");
			ClosePopUp.Click();
		}
	}
}
