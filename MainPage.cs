using System;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;


namespace PlaywrightTests
{
    public class MainPage
    {
        private readonly IPage _page;
        private readonly ILocator _locator;

        private readonly string URL = "https://www.saucedemo.com/";

        public MainPage(IPage page)
        {
            _page = page;
            _locator = page.Locator("#something");

        }

        public async Task GoTo()
        {
            await _page.GotoAsync(URL);
        }
    }
}
