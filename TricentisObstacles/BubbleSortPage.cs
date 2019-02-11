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
	class BubbleSortPage
	{
		public BubbleSortPage()
		{
			PageFactory.InitElements(PropertiesCollection.driver, this);
		}

		[FindsBy(How = How.Id, Using = "button1")]
		public IWebElement Swap { get; set; }

		[FindsBy(How = How.Id, Using = "button2")]
		public IWebElement Next { get; set; }

		[FindsBy(How = How.Id, Using = "sample")]
		public IWebElement Done { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/div[7]/button[1]")]
		public IWebElement ClosePopUp { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/h2")]
		public IWebElement Completed { get; set; }

		public void test()
		{
			int i = 1;
			bool notDone = true;
			while (notDone)
			{
				IWebElement bubble = PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[2]/div[1]/div[1]/div[2]/div/div[2]/div/div[" + i + "]"));
				int num1 = Convert.ToInt32(PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[2]/div[1]/div[1]/div[2]/div/div[2]/div/div[" + i + "]/div[1]")).Text);
				int num2 = Convert.ToInt32(PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[2]/div[1]/div[1]/div[2]/div/div[2]/div/div[" + i + "]/div[2]")).Text);
				if (num1 > num2)
				{
					Swap.Click();
					Thread.Sleep(250);
					Next.Click();
					Thread.Sleep(250);
					i++;
				}
				else
				{
					Next.Click();
					Thread.Sleep(250);
					i++;
				}
				Console.WriteLine(i);
				if (i == 9 && Done.Text.Equals("KEEP SORTING"))
				{
					i = 1;
					Thread.Sleep(150);
				}
				if (!(Done.Text.Equals("KEEP SORTING")))
				{
					notDone = false;
				}
			}
			Done.Click();
			Thread.Sleep(800);
			Assert.IsTrue(Completed.Text.Contains("Good job"), "Not Completed");
			ClosePopUp.Click();
		}
	}
}
