using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
	class Program
	{
		static void Main(string[] args)
		{
		}

		[SetUp]
		public void Initialize()
		{
			PropertiesCollection.driver = new ChromeDriver();
			PropertiesCollection.driver.Navigate().GoToUrl("https://obstaclecourse.tricentis.com/Account/Login");

			IWebElement username = PropertiesCollection.driver.FindElement(By.Id("UserName"));
			IWebElement password = PropertiesCollection.driver.FindElement(By.Id("Password"));
			IWebElement submitBtn = PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div/form/div[3]/button"));
			SetMethods.EnterText(username, "long@planittesting.com");
			SetMethods.EnterText(password, "tct2018P@ss");
			submitBtn.Click();
			//WebDriverWait waitForElement = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(5));
			//waitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"undefined-sticky-wrapper\"]/div/div/div[1]/a/img")));
		}

		[Test]
		public void ClickMePage22505()
		{
			PropertiesCollection.driver.Navigate().GoToUrl("https://obstaclecourse.tricentis.com/Obstacles/22505/retry");
			Thread.Sleep(750);

			ClickMePage page1 = new ClickMePage();
			page1.test();
		}
		[Test]
		public void IAmTheOnePage12952()
		{
			PropertiesCollection.driver.Navigate().GoToUrl("https://obstaclecourse.tricentis.com/Obstacles/12952/retry");
			Thread.Sleep(750);

			IAmTheOnePage page2 = new IAmTheOnePage();
			page2.test();
		}
		[Test]
		public void TableOrderIDPage64161()
		{
			PropertiesCollection.driver.Navigate().GoToUrl("https://obstaclecourse.tricentis.com/Obstacles/64161/retry");
			Thread.Sleep(750);

			TableOrderIDPage page3 = new TableOrderIDPage();
			page3.test();
		}
		[Test]
		public void ClickMeTwicePage72954()
		{
			PropertiesCollection.driver.Navigate().GoToUrl("https://obstaclecourse.tricentis.com/Obstacles/72954/retry");
			Thread.Sleep(750);

			ClickMeTwicePage page4 = new ClickMeTwicePage();
			page4.test();
		}
		[Test]
		public void JohnDoeTablePage92248()
		{
			PropertiesCollection.driver.Navigate().GoToUrl("https://obstaclecourse.tricentis.com/Obstacles/92248/retry");
			Thread.Sleep(750);

			JohnDoeTablePage page5 = new JohnDoeTablePage();
			page5.test();
		}
		[Test]
		public void MultiSelectPage94441()
		{
			PropertiesCollection.driver.Navigate().GoToUrl("https://obstaclecourse.tricentis.com/Obstacles/94441/retry");
			Thread.Sleep(750);

			MultiSelectPage page6 = new MultiSelectPage();
			page6.test();
		}
		[Test]
		public void CountEntriesPage24499()
		{
			PropertiesCollection.driver.Navigate().GoToUrl("https://obstaclecourse.tricentis.com/Obstacles/24499/retry");
			Thread.Sleep(750);

			CountEntriesPage page7 = new CountEntriesPage();
			page7.test();
		}
		[Test]
		public void CalculateBarPage33678()
		{
			PropertiesCollection.driver.Navigate().GoToUrl("https://obstaclecourse.tricentis.com/Obstacles/33678/retry");
			Thread.Sleep(750);

			CalculateBarPage page8 = new CalculateBarPage();
			page8.test();
		}
		[Test]
		public void ToscabotFlyPage60469()
		{
			PropertiesCollection.driver.Navigate().GoToUrl("https://obstaclecourse.tricentis.com/Obstacles/60469/retry");
			Thread.Sleep(750);

			ToscabotFlyPage page9 = new ToscabotFlyPage();
			page9.test();
		}
		[Test]
		public void MoveTasksPage23292()
		{
			PropertiesCollection.driver.Navigate().GoToUrl("https://obstaclecourse.tricentis.com/Obstacles/23292/retry");
			Thread.Sleep(750);

			MoveTasksPage page10 = new MoveTasksPage();
			page10.test();
		}
		[Test]
		public void ExtractTextPage81012()
		{
			PropertiesCollection.driver.Navigate().GoToUrl("https://obstaclecourse.tricentis.com/Obstacles/81012/retry");
			Thread.Sleep(750);

			ExtractTextPage page11 = new ExtractTextPage();
			page11.test();
		}
		[Test]
		public void AdditionPage78264()
		{
			PropertiesCollection.driver.Navigate().GoToUrl("https://obstaclecourse.tricentis.com/Obstacles/78264/retry");
			Thread.Sleep(750);

			AdditionPage page12 = new AdditionPage();
			page12.test();
		}
		[Test]
		public void BookISBNPage87912()
		{
			PropertiesCollection.driver.Navigate().GoToUrl("https://obstaclecourse.tricentis.com/Obstacles/87912/retry");
			Thread.Sleep(750);

			BookISBNPage page13 = new BookISBNPage();
			page13.test();
		}
		[Test]
		public void ToughCookiePage45618()
		{
			PropertiesCollection.driver.Navigate().GoToUrl("https://obstaclecourse.tricentis.com/Obstacles/45618/retry");
			Thread.Sleep(750);

			ToughCookiePage page14 = new ToughCookiePage();
			page14.test();
		}
		[Test]
		public void ConfusingDatesPage57683()
		{
			PropertiesCollection.driver.Navigate().GoToUrl("https://obstaclecourse.tricentis.com/Obstacles/57683/retry");
			Thread.Sleep(750);

			ConfusingDatesPage page15 = new ConfusingDatesPage();
			page15.test();
		}
		[Test]
		public void ClickMeMorePage81121()
		{
			PropertiesCollection.driver.Navigate().GoToUrl("https://obstaclecourse.tricentis.com/Obstacles/81121/retry");
			Thread.Sleep(750);

			ClickMeMorePage page16 = new ClickMeMorePage();
			page16.test();
		}
		[Test]
		public void ClosePopUpPage51130()
		{
			PropertiesCollection.driver.Navigate().GoToUrl("https://obstaclecourse.tricentis.com/Obstacles/51130/retry");
			Thread.Sleep(750);

			ClosePopUpPage page17 = new ClosePopUpPage();
			page17.test();
		}
		[Test]
		public void TomorrowDatePage19875()
		{
			PropertiesCollection.driver.Navigate().GoToUrl("https://obstaclecourse.tricentis.com/Obstacles/19875/retry");
			Thread.Sleep(750);

			TomorrowDatePage page18 = new TomorrowDatePage();
			page18.test();
		}
		[Test]
		public void CountRowsPage41032()
		{
			PropertiesCollection.driver.Navigate().GoToUrl("https://obstaclecourse.tricentis.com/Obstacles/41032/retry");
			Thread.Sleep(750);

			CountRowsPage page19 = new CountRowsPage();
			page19.test();
		}
		[Test]
		public void LastRowPage70310()
		{
			PropertiesCollection.driver.Navigate().GoToUrl("https://obstaclecourse.tricentis.com/Obstacles/70310/retry");
			Thread.Sleep(750);

			LastRowPage page20 = new LastRowPage();
			page20.test();
		}
		[Test]
		public void MathsPage32403()
		{
			PropertiesCollection.driver.Navigate().GoToUrl("https://obstaclecourse.tricentis.com/Obstacles/32403/retry");
			Thread.Sleep(750);

			MathsPage page21 = new MathsPage();
			page21.test();
		}
		[Test]
		public void ClickRightSidePage41038()
		{
			PropertiesCollection.driver.Navigate().GoToUrl("https://obstaclecourse.tricentis.com/Obstacles/41038/retry");
			Thread.Sleep(750);

			ClickRightSidePage page22 = new ClickRightSidePage();
			page22.test();
		}
		[Test]
		public void MovingButtonPage41040()
		{
			PropertiesCollection.driver.Navigate().GoToUrl("https://obstaclecourse.tricentis.com/Obstacles/41040/retry");
			Thread.Sleep(750);

			MovingButtonPage page23 = new MovingButtonPage();
			page23.test();
		}
		[Test]
		public void HiddenElementPage66666()
		{
			PropertiesCollection.driver.Navigate().GoToUrl("https://obstaclecourse.tricentis.com/Obstacles/66666/retry");
			Thread.Sleep(750);

			HiddenElementPage page24 = new HiddenElementPage();
			page24.test();
		}
		[Test]
		public void MazePage66667()
		{
			PropertiesCollection.driver.Navigate().GoToUrl("https://obstaclecourse.tricentis.com/Obstacles/66667/retry");
			Thread.Sleep(750);

			MazePage page25 = new MazePage();
			page25.test();
		}
		[Test]
		public void DropDownPage14090()
		{
			PropertiesCollection.driver.Navigate().GoToUrl("https://obstaclecourse.tricentis.com/Obstacles/14090/retry");
			Thread.Sleep(750);

			DropDownPage page26 = new DropDownPage();
			page26.test();
		}
		[Test]
		public void ScrollPage99999()
		{
			PropertiesCollection.driver.Navigate().GoToUrl("https://obstaclecourse.tricentis.com/Obstacles/99999/retry");
			Thread.Sleep(750);

			ScrollPage page27 = new ScrollPage();
			page27.test();
		}
		[Test]
		public void SuesNumberPage72946()
		{
			PropertiesCollection.driver.Navigate().GoToUrl("https://obstaclecourse.tricentis.com/Obstacles/72946/retry");
			Thread.Sleep(750);

			SuesNumberPage page28 = new SuesNumberPage();
			page28.test();
		}
		[Test]
		public void SmartButtonPage87361()
		{
			PropertiesCollection.driver.Navigate().GoToUrl("https://obstaclecourse.tricentis.com/Obstacles/87361/retry");
			Thread.Sleep(750);

			SmartButtonPage page29 = new SmartButtonPage();
			page29.test();
		}
		[Test]
		public void ChristmasDayPage21269()
		{
			PropertiesCollection.driver.Navigate().GoToUrl("https://obstaclecourse.tricentis.com/Obstacles/21269/retry");
			Thread.Sleep(750);

			ChristmasDayPage page30= new ChristmasDayPage();
			page30.test();
		}
		[Test]
		public void ClickRedLinePage30034()
		{
			PropertiesCollection.driver.Navigate().GoToUrl("https://obstaclecourse.tricentis.com/Obstacles/30034/retry");
			Thread.Sleep(750);

			ClickRedLinePage page31 = new ClickRedLinePage();
			page31.test();
		}
		[Test]
		public void DDLComboPage73588()
		{
			PropertiesCollection.driver.Navigate().GoToUrl("https://obstaclecourse.tricentis.com/Obstacles/73588/retry");
			Thread.Sleep(750);

			DDLComboPage page32 = new DDLComboPage();
			page32.test();
		}
		[Test]
		public void BubbleSortPage73589()
		{
			PropertiesCollection.driver.Navigate().GoToUrl("https://obstaclecourse.tricentis.com/Obstacles/73589/retry");
			Thread.Sleep(750);

			BubbleSortPage page33 = new BubbleSortPage();
			page33.test();
		}
		[Test]
		public void FillInPage73590()
		{
			PropertiesCollection.driver.Navigate().GoToUrl("https://obstaclecourse.tricentis.com/Obstacles/73590/retry");
			Thread.Sleep(750);

			FillInPage page34 = new FillInPage();
			page34.test();
		}

		[TearDown]
		public void CleanUp()
		{
			PropertiesCollection.driver.Close();
		}
	}
}
