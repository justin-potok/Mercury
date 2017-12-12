using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercuryAirlineTest
{

    public static class TestData
    {

        public static List<TestItem> Data()
        {

            string radio = "Radio";
            string dropDown = "DropDown";
            string textBox = "TextBox";
            string button = "Button";

            List<TestItem> testItems = new List<TestItem>();

            //The below are the specific details for the test.
            //They must be in the correct order for the test to work.
            //If errors occur, check the below values are equal to the elements on the web page

            testItems.Add(new TestItem
            {
                InputName = "userName", //name of element on web page from 'inspect element'
                InputValue = "mercury", //data for the software to enter into above element
                InputType = textBox     //type of element that is expected to be encountered (from the list above)
            });
            testItems.Add(new TestItem
            {
                InputName = "password",
                InputValue = "mercury",
                InputType = textBox
            });
            testItems.Add(new TestItem
            {
                InputName = "login",
                InputType = button
            });
            testItems.Add(new TestItem
            {
                InputName = "tripType",
                InputValue = "oneway",
                InputType = radio
            });
            testItems.Add(new TestItem
            {
                InputName = "fromPort",
                InputValue = "Sydney",
                InputType = dropDown
            });
            testItems.Add(new TestItem
            {
                InputName = "toPort",
                InputValue = "London",
                InputType = dropDown
            });
            testItems.Add(new TestItem
            {
                InputName = "servClass",
                InputValue = "First",
                InputType = radio
            });
            testItems.Add(new TestItem
            {
                InputName = "findFlights",
                InputType = button
            });
            testItems.Add(new TestItem
            {
                InputName = "reserveFlights",
                InputType = button
            });
            testItems.Add(new TestItem
            {
                InputName = "passFirst0",
                InputValue = "TestFirstName",
                InputType = textBox
            });
            testItems.Add(new TestItem
            {
                InputName = "passLast0",
                InputValue = "TestLastName",
                InputType = textBox
            });
            testItems.Add(new TestItem
            {
                InputName = "creditnumber",
                InputValue = "1234567890",
                InputType = textBox
            });
            testItems.Add(new TestItem
            {
                InputName = "ticketLess",
                InputType = button
            });
            testItems.Add(new TestItem
            {
                InputName = "buyFlights",
                InputType = button
            });

            return testItems;
        }
    }
}
