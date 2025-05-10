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
            
            await Expect(Page).ToHaveTitleAsync("Practice Software Testing - Toolshop - v5.0");
        }

        public async Task VerifyInValidLogin()
        {
            
        }
    }
}
