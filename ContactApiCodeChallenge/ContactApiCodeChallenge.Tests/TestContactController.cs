using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContactApiCodeChallenge.Interfaces;
using ContactApiCodeChallenge.Factory;
using ContactApiCodeChallenge.Models;
using ContactApiCodeChallenge.Controllers;

namespace ContactApiCodeChallenge.Tests
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
