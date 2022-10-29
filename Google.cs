using Docker.DotNet.Models;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V104.Cast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace TestWorkT
{
    internal class Program
    {
        static void Log(string message)
        {
            File.AppendAllText("logPars.txt", message + "\n");
        }
        static  void Pars()
        {
            Log("Запуск программы" + DateTime.Now);
            IWebDriver driver = new ChromeDriver();
            driver.Url = @"https://www.google.com/";
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    driver.FindElement(By.Name("q"));
                    break;
                }
                catch(Exception)
                {
                    Thread.Sleep(2000);
                }
            }
            driver.FindElement(By.Name("q")).SendKeys("Hello World");
            Thread.Sleep(2000);
            IWebElement ele1 = driver.FindElement(By.Name("btnK"));
            ele1.Click();
            string title = driver.Title;
            Console.WriteLine(title);
            Log(title);
            Thread.Sleep(1000);
            driver.Close();
            Log("Завершение программы" + DateTime.Now);
        }


        static  void Main(string[] args)
        {
            Pars();
        }
    }
}