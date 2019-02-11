using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace TricentisObstacles
{
	class BookISBNPage
	{
		public BookISBNPage()
		{
			PageFactory.InitElements(PropertiesCollection.driver, this);
		}

		[FindsBy(How = How.Id, Using = "loadbooks")]
		public IWebElement booksBtn { get; set; }

		[FindsBy(How = How.Id, Using = "books")]
		public IWebElement XMLText { get; set; }

		[FindsBy(How = How.Id, Using = "isbn")]
		public IWebElement result { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/div[7]/button[1]")]
		public IWebElement ClosePopUp { get; set; }

		[FindsBy(How = How.XPath, Using = "/html/body/div[5]/h2")]
		public IWebElement Completed { get; set; }

		public void test()
		{
			booksBtn.Click();
			string text = GetMethods.GetTextValue(XMLText);
			Console.WriteLine(text);
			
			// Copy and save into an XML file
			using (StreamWriter sw = File.CreateText(@"C:\Users\long\Documents\xmldoc.xml"))
			{
				sw.WriteLine(text);
			}

			// Read from the saved XML file
			XmlTextReader reader = new XmlTextReader(@"C:\Users\long\Documents\xmldoc.xml");
			string ISBN = "";
			while (reader.Read())
			{
				if (reader.NodeType.ToString().Equals("Element"))
				{
					if (reader.Name.Equals("title"))
					{
						reader.Read();
						if (reader.NodeType.ToString().Equals("Text"))
						{
							if (reader.Value.ToString().Equals("Testing Computer Software"))
							{ 
								
								// Read until ISBN row is reached
								for (int i = 0; i < 12; i++)
								{
									reader.Read();
								}
								ISBN = reader.Value.ToString();
								break;
							}
						}
					}
				}
			}
			SetMethods.EnterText(result, ISBN);
			Thread.Sleep(800);
			Assert.IsTrue(Completed.Text.Contains("Good job"), "Not Completed");
			ClosePopUp.Click();
		}
	}
}
