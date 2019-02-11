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
	class ClickMeTwicePage
	{
		public ClickMeTwicePage()
		{
			PageFactory.InitElements(PropertiesCollection.driver, this);
		}

		[FindsBy(How = How.Id, Using = "rnd_46576")]
		public IWebElement ClickMeOnce { get; set; }

		[FindsBy(How = How.CssSelector, Using = ".btn.theme-btn-color.btn-lg.animated.fadeInDown.delay-1.btn-big")]
		public IWebElement ClickMeTwice { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/div[7]/button[1]")]
		public IWebElement ClosePopUp { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/h2")]
		public IWebElement Completed { get; set; }

		public void test()
		{
			ClickMeOnce.Click();
			Thread.Sleep(800);
			ClickMeTwice.Click();
			Thread.Sleep(800);
			Assert.IsTrue(Completed.Text.Contains("Good job"), "Not Completed");
			ClosePopUp.Click();
		}
	}
}