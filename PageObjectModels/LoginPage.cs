using Microsoft.Playwright;
using NUnit.Framework;
using Microsoft.Playwright.NUnit;

namespace PlaywrightTests.PageObjectModels
{
    public class LoginPage
    {
        private readonly IPage _page;
        public LoginPage(IPage page)
        {
            _page = page;
        }
        public async Task NavigateToLoginPage()
        {
            await _page.GotoAsync("https://practicesoftwaretesting.com/");
        }

        public async Task PageElements()
        {
            var loginLink = _page.GetByRole(AriaRole.Link, new() { Name = "Login" });
            await loginLink.ClickAsync();
        }

        public async Task EnterUsername(string username)
        {
            var locator = _page.Locator("//input[@id='user-name']");
            await locator.FillAsync(username);
        }
    }
}
