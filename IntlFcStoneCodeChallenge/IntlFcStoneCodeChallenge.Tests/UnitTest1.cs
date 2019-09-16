using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntlFcStoneCodeChallenge;
using IntlFcStoneCodeChallenge.Interfaces;
using IntlFcStoneCodeChallenge.Factory;

namespace IntlFcStoneCodeChallenge.Tests
{
    [TestClass]
    public class UnitTest1
    {
        IContactRepository _repository;

        [TestInitialize]
        public void TestInit()
        {
            _repository = ContactRepositoryFactory.GetContactRespository;
        }

        [TestMethod]
        public void TestGetAll()
        {
            Assert.AreEqual(_repository.GetAllEntities().Count, 10);
        }
    }
}
