using Microsoft.Playwright;
using NUnit.Framework;

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
            await Page
                .GetByRole(AriaRole.Link, new() { Name = "Login" })

        }

        public async Task EnterUsername(string username)
        {
            await _page.FillAsync("//input[@id='user-name']", username);
        }

    }
}