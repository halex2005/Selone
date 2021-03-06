﻿using Kontur.Selone.Selectors;
using OpenQA.Selenium;

namespace Kontur.Selone.Elements
{
    public class WebElementsCollection : ElementsCollection<IWebElement>
    {
        public WebElementsCollection(ISearchContext searchContext, ItemByLambda itemByLambda)
            : base(searchContext, itemByLambda, CreateWebElementWrapper)
        {
        }

        public WebElementsCollection(ISearchContext searchContext, ItemBy itemBy)
            : base(searchContext, itemBy, CreateWebElementWrapper)
        {
        }

        private static IWebElement CreateWebElementWrapper(ISearchContext searchContext, By by, IWebElement element)
        {
            return new WebElementWrapper(searchContext, by, element);
        }
    }
}