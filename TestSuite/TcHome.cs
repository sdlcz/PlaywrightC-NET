using Microsoft.Playwright;
using NUnit.Framework;
using PlaywrightTests.PageObjectModels;
using Microsoft.Playwright.NUnit;


namespace PlaywrightTests.TestSuite
{
	[Parallelizable(ParallelScope.Self)]
	[TestFixture]
	public class TcHome : PageTest
	{
		private LoginPage _loginPage;
		[SetUp]
		public async Task SetUp()
		{
			_loginPage = new LoginPage(Page);
			await _loginPage.NavigateToLoginPage();
			var homePage = new HomePage(Page);
			await homePage.InitializeAsync();

		}
		[Test]
		public async Task VerifyPageElement()
		{
			var homePage = new HomePage(Page); 
			await homePage.NavigateToHomePage();
			await Expect(Page).ToHaveTitleAsync("Practice Software Testing - Toolshop - v5.0");
		}
	}
}