using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Playwright.NUnit;
using System.Threading.Tasks;

namespace PlaywrightTests
{
    public class AnotherPage : PageTest
    {
        private readonly IPage _page;
        private readonly ILocator userNameInput;

        private readonly string URL = "https://www.saucedemo.com/";

        public AnotherPage(IPage page)
        {
            _page = page;
            userNameInput = page.Locator("#user-name");

        }

        public async Task LogInAsStandardUser()
        {
            await userNameInput.TypeAsync("standard_user");
            await _page.TypeAsync("#password", "secret_sauce");
            await _page.ClickAsync(".submit-button");
            await Expect(_page.Locator(".title")).ToHaveTextAsync("Products");
        }
    }
}
