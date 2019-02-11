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
	class DropDownPage
	{
		public DropDownPage()
		{
			PageFactory.InitElements(PropertiesCollection.driver, this);
		}

		[FindsBy(How = How.Id, Using = "generate")]
		public IWebElement GenerateBtn { get; set; }

		[FindsBy(How = How.Id, Using = "submit")]
		public IWebElement SubmitBtn { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/div[7]/button[1]")]
		public IWebElement ClosePopUp { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/h2")]
		public IWebElement Completed { get; set; }

		public void test()
		{
			GenerateBtn.Click();
			for (int i = 2; i < 7; i++)
			{
				IWebElement letter = PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[2]/div[1]/div[1]/div[2]/div/div[2]/div[2]/div[2]/table/tr[" + i + "]/td[1]"));
				IWebElement ddl = PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[2]/div[1]/div[1]/div[2]/div/div[2]/div[2]/div[2]/table/tr[" + i + "]/td[2]/select"));
				SelectElement selectList = new SelectElement(ddl);
				IList<IWebElement> options = selectList.Options;
				for (int j = 1; j < 6; j++)
				{
					string optionText = options[j].Text.ToString();
					if (CheckLetter(letter.Text).Equals(optionText.Substring(0, 1)))
					{
						SetMethods.SelectDropDown(ddl, optionText);
						break;
					}
				}
			}
			SubmitBtn.Click();
			Thread.Sleep(800);
			Assert.IsTrue(Completed.Text.Contains("Good job"), "Not Completed");
			ClosePopUp.Click();
		}
		private string CheckLetter(string x)
		{
			return x.Substring(37);
		}
	}
}