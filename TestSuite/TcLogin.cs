using Microsoft.Playwright;
using NUnit.Framework;
using Microsoft.Playwright.NUnit;
using PlaywrightTests.PageObjectModels;

namespace PlaywrightTests.TestSuite
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    public class TcLogin : PageTest
    {
        [SetUp]
        public async Task SetUp()
        {
            await Page.GotoAsync("https://practicesoftwaretesting.com/");
        }

        [Test]
        public async Task VerifyPageElement()
        {
            await Task.Delay(100); // Placeholder logic
            await Expect(Page).ToHaveTitleAsync("Practice Software Testing");
        }

        public async Task VerifyInValidLogin()
        {
            await Task.Delay(100); // Placeholder logic
        }
    }
}
