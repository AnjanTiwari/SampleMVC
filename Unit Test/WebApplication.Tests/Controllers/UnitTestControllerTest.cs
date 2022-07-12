using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebApplication.Controllers;

namespace WebApplication.Tests.Controllers
{

    /*
     >Unit testing is component of TDD
    >It is first level of testing done by developers,
    to test small units of source code(Class,methods...)
    >Aby change that you can't find at compile time 
    >changes valueof any parammeters
    >Any unit test ismade up of 3 things,
     Arrange-Setup the test data, Act-perform the actual test, Assert- Verify the result
     
     
     */
    [TestClass]
    public class UnitTestControllerTest
    {
        [TestMethod]
        public void TestIndex()
        {
            //Arrange
            UnitTestController utc = new UnitTestController();

            //Act
            ViewResult result = utc.Index() as ViewResult;

            //Assert
            Assert.AreEqual("Well Done", utc.ViewData["Hey"]);


        }

        [TestMethod]
        public void TestShow()
        {
            //Arrange
            UnitTestController utc1 = new UnitTestController()
;
            //Act

            ViewResult reult = utc1.Show(3) as ViewResult;

            //Assert

            Assert.AreEqual("Odd Number", utc1.ViewData["Number"]);
        }
    }
}
