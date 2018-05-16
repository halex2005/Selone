﻿using Kontur.Selone.Extensions;
using Kontur.Selone.Tests.Browsers.Factories;
using Kontur.Selone.WebDrivers;

namespace Kontur.Selone.Tests.Browsers
{
    public static class BrowserPool
    {
        public static readonly ChromeDriverFactory ChromeDriverFactory = new ChromeDriverFactory(new ChromeDriverFactoryConfiguration
        {
            ChromeDirectoryPath = @"C:\browsers\Chrome",
            DriverDirectoryPath = @"C:\browsers\Chrome",
            WindowSize = new WindowSize {Width = 800, Height = 600}
        });

        public static readonly InternetExplorerDriverFactory InternetExplorerDriverFactory = new InternetExplorerDriverFactory(new InternetExplorerDriverFactoryConfiguration
        {
            DriverDirectoryPath = @"C:\browsers\IE"
        });

        private static readonly DelegateWebDriverCleaner cleaner = new DelegateWebDriverCleaner(x => x.ResetWindows());

        public static readonly IWebDriverKeyedPool<Browser> Instance =
            new WebDriverKeyedPool<Browser>()
                .Register(Browser.Chrome, ChromeDriverFactory, cleaner)
                .Register(Browser.Ie, InternetExplorerDriverFactory, cleaner);
    }
}