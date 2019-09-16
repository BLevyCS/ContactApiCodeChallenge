using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntlFcStoneCodeChallengeTests.RepositoryTests
{
    [TestClass]
    public class TestBaseRepository
    {
        IContactRepository _repository;

        [TestInitialize]
        public void TestInit()
        {
            _repository = ContactRepositoryFactory.GetContactRespository;
    }

        [TestMethod]
        public void TestMethod1()
        {

        }
    }
}
