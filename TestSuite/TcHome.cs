using Microsoft.Playwright;
using NUnit.Framework;
using PlaywrightTests.PageObjectModels;

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
		}
		[Test]
		public async Task VerifyPageElement()
		{
			await expect(Page).ToHaveTitleAsync("Practice Software Testing");
		}
	}
}