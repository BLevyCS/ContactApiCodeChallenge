using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntlFcStoneCodeChallenge.Interfaces;
using IntlFcStoneCodeChallenge.Factory;
using IntlFcStoneCodeChallenge.Models;
using IntlFcStoneCodeChallenge.Controllers;

namespace IntlFcStoneCodeChallenge.Tests
{
    [TestClass]
    public class TestContactController
    {
        ContactController controller;

        [TestMethod]
        public void TestGetAll()
        {
            controller = new ContactController();
            Assert.AreEqual(controller.GetAllContacts().Count, 10);
        }
    }
}
