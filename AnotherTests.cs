using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaywrightTests
{
    [Parallelizable(ParallelScope.Self)]
    public class AnotherTests : PageTest
    {

        [SetUp]
        public async Task InitializeAsync()
        {   // we dont need that when inheriting from PageTest
            /*
            playwright = await Microsoft.Playwright.Playwright.CreateAsync();
            var chrome = playwright.Chromium;
            browser = await chrome.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            page = await browser.NewPageAsync();
            */
        }

        [Test]
        public async Task GoToPageAndLogIn()
        {
            MainPage mainPage = new MainPage(Page);
            AnotherPage anotherPage = new AnotherPage(Page);
            await mainPage.GoTo();
            await anotherPage.LogInAsStandardUser();
        }
    }
}
