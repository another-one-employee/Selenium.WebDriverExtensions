using OpenQA.Selenium;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium.WebDriverExtensions
{
    public static class WebElementExtensions
    {
        public static void TypeWithDelay(IWebElement element, string text, int delayInMs)
        {
            foreach (char c in text)
            {
                element.SendKeys(c.ToString());
                Thread.Sleep(delayInMs);
            }
        }

        public static void TypeWithDelay(IWebElement element, string text, TimeSpan delay)
        {
            foreach (char c in text)
            {
                element.SendKeys(c.ToString());
                Thread.Sleep(delay);
            }
        }

        public static async Task TypeWithDelayAsync(IWebElement element, string text, int delayInMs)
        {
            foreach (char c in text)
            {
                element.SendKeys(c.ToString());
                await Task.Delay(delayInMs);
            }
        }

        public static async Task TypeWithDelayAsync(IWebElement element, string text, TimeSpan delay)
        {
            foreach (char c in text)
            {
                element.SendKeys(c.ToString());
                await Task.Delay(delay);
            }
        }
    }
}