using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignUpAutomationATG
{
    class SignUpObjects
    {
        public SignUpObjects() => PageFactory.InitElements(PropertyCollection.Driver, this);

        [FindsBy(How = How.CssSelector, Using = "#toprightnavbar > li:nth-child(6) > a")]
        public IWebElement BtnSignUp { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#first_name")]
        public IWebElement TxtFirstName { get; set; }

        [FindsBy(How = How.Id, Using = "last_name")]
        public IWebElement TxtLastName { get; set; }

        [FindsBy(How = How.Id, Using = "user_email")]
        public IWebElement TxtEmail { get; set; }

        [FindsBy(How = How.Id, Using = "user_password")]
        public IWebElement TxtPass { get; set; }

        [FindsBy(How = How.Id, Using = "cnf_user_password")]
        public IWebElement TxtConfPass { get; set; }

        [FindsBy(How = How.Id, Using = "btn_register")]
        public IWebElement BtnRegister { get; set; }

        public void SignUpFormFillup(string[] data)
        {
            // This method is currently giving a lot of issues. Let's see what can be done.
            TxtFirstName.SendKeys(data[0]);
            TxtLastName.SendKeys(data[1]);
            TxtEmail.SendKeys(data[2]);
            TxtPass.SendKeys("123456");
            TxtConfPass.SendKeys("123456");
            
        }
    }
}
