using Microsoft.Playwright;
using NUnit.Framework;

namespace PlaywrightTests.PageObjectModels
{
    public class HomePage
    {
        private readonly IPage _page;
        public HomePage(IPage page)
        {
            _page = page;
        }
        public async Task NavigateToHomePage()
        {
            await _page.GotoAsync("https://practicesoftwaretesting.com/");
        }
        public async Task PageElements()
        {
            await _page.GetByRole(AriaRole.Link, new() { Name = "" });
        }
    }
}