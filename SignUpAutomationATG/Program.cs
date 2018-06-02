using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SignUpAutomationATG
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = new string[] { "Mota", "Boda", "MotaBoda@google.com" };
            //for (var i = 0; i < 10; i++)
            {
                // Opening chrome
                PropertyCollection.Driver = new ChromeDriver();
                PropertyCollection.Driver.Navigate().GoToUrl("http://atg.party/");
                Console.WriteLine("URL opened.");
                
                SignUpObjects so = new SignUpObjects();
                so.BtnSignUp.Click(); // Issue faced here is fixed
                so.SignUpFormFillup(data); // New issue faced here
            }
        }
    }
}
