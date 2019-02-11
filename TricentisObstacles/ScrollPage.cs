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
	class ScrollPage
	{
		public ScrollPage()
		{
			PageFactory.InitElements(PropertiesCollection.driver, this);
		}

		[FindsBy(How = How.Id, Using = "container")]
		public IWebElement Container { get; set; }

		[FindsBy(How = How.XPath, Using = "//*[@id=\"textfield\"]")]
		public IWebElement TextBox { get; set; }

		[FindsBy(How = How.Id, Using = "submit")]
		public IWebElement SubmitBtn { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/div[7]/button[1]")]
		public IWebElement ClosePopUp { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/h2")]
		public IWebElement Completed { get; set; }

		public void test()
		{
			// Focuses on small window to scroll
			PropertiesCollection.driver.SwitchTo().Frame(PropertiesCollection.driver.FindElement(By.Id("container")));

			// Implement javascript to scroll window
			IJavaScriptExecutor js = (IJavaScriptExecutor)PropertiesCollection.driver;
			js.ExecuteScript("window.scrollBy(0,200)");

			SetMethods.EnterText(TextBox, "Tosca");

			// Focus back on entire html page
			PropertiesCollection.driver.SwitchTo().DefaultContent();

			SubmitBtn.Click();
			Thread.Sleep(800);
			Assert.IsTrue(Completed.Text.Contains("Good job"), "Not Completed");
			ClosePopUp.Click();
		}
	}
}
