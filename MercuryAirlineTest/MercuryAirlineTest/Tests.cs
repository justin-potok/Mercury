using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Collections;
using System.Linq;
using MercuryAirlineTest;
using System.Collections.Generic;

namespace MercuryAirlineTests
{

    [TestClass]

    public class Tests
    {

        IWebDriver driverOne = new FirefoxDriver();

        [TestMethod]

        public void AirlineTest()
        {

            try
            {

                driverOne.Navigate().GoToUrl("http://newtours.demoaut.com/mercurywelcome.php");
                RunTest();
                Console.WriteLine("\nTestPassed");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException != null ? ex.InnerException.ToString() : ex.Message);
            }
        }


        private IWebElement FindElement(string driver)
        { //making the rest easier to read
            return driverOne.FindElement(By.Name(driver));
        }


        private void RunTest()
        {

            List<TestItem> testData = TestData.Data();

            foreach (var dataItem in testData)
            {

                if (dataItem.InputType == "TextBox")
                {
                    IWebElement textBoxName = FindElement(dataItem.InputName);  //find textbox by name
                    textBoxName.SendKeys(dataItem.InputValue);  //write value in textbox
                }

                if (dataItem.InputType == "Radio")
                {
                    var radioName = driverOne.FindElements(By.Name(dataItem.InputName));    //find radio button list by name

                    for (int i = 0; i < radioName.Count(); i++)
                    {
                        if (radioName[i].GetAttribute("value") == dataItem.InputValue)
                        {    //find specific radio button 
                            radioName[i].Click();  //select radio button
                            i = radioName.Count(); //finish loop early as only 1 item can be selected
                        }
                    }
                }

                if (dataItem.InputType == "DropDown")
                {
                    var listName = FindElement(dataItem.InputName); //find dropdown list by name
                    var selectListElement = new SelectElement(listName);
                    selectListElement.SelectByValue(dataItem.InputValue);   //select specific list element
                }
                if (dataItem.InputType == "Button")
                {
                    IWebElement buttonName = FindElement(dataItem.InputName);   //find button by name
                    buttonName.Click(); //click button
                }
            }
        }
    }
}
