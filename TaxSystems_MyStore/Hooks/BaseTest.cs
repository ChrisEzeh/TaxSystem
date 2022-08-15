using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;


namespace TaxSystems_MyStore.Hooks
{
    [Binding]
    public class BaseTest
    {
        public static IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();



            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3000);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
            Kill("chromedriver");
        }
        public static void Kill(string processName)
        {
            try
            {
                Process[] runingProcesses = Process.GetProcesses();
                foreach (var process in runingProcesses)
                {
                    if (process.ProcessName.Contains(processName))
                    {
                        process.Kill();
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        //public void AfterScenario()
        //{
        //    driver.Close();
        //    driver.Dispose();

        //}
    }
}
