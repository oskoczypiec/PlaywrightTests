using System;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightTests
{
    [Parallelizable(ParallelScope.Self)]
    public class MyTest
    {
        public IPlaywright playwright { get; private set; }
        public IBrowser browser { get; private set; }

        [SetUp]
        public async Task InitializeAsync()
        {
            playwright = await Playwright.CreateAsync();
            var chrome = playwright.Chromium;
            browser = await chrome.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
        }

        [Test]
        public async Task GoToPage()
        {
            
            MainPage mainPage = new MainPage(await browser.NewPageAsync());
            await mainPage.GoTo();
        }
    }
}