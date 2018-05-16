﻿using Kontur.Selone.Tests.Browsers.Factories;
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

        public static readonly WebDriverPools<Browser> Instance =
            new WebDriverPools<Browser>()
                .Register(Browser.Chrome, ChromeDriverFactory)
                .Register(Browser.Ie, InternetExplorerDriverFactory);
    }
}