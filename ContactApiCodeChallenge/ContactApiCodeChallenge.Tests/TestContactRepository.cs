using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContactApiCodeChallenge.Interfaces;
using ContactApiCodeChallenge.Factory;
using ContactApiCodeChallenge.Models;

namespace ContactApiCodeChallenge.Tests
{
    [TestClass]
    public class TestContactRepository
    {
        IContactRepository _repository;

        [TestMethod]
        public void TestGetAll()
        {
            _repository = ContactRepositoryFactory.GetFilledContactRespository;
            Assert.AreEqual(10, _repository.GetAllEntities().Count);
            _repository.Dispose();
        }

        [TestMethod]
        public void TestDelete()
        {
            _repository = ContactRepositoryFactory.GetFilledContactRespository;
            Contact contact;
            _repository.Delete(0, out contact);
            Assert.AreEqual(9, _repository.GetAllEntities().Count);
            _repository.Dispose();
        }

        [TestMethod]
        public void TestCreate()
        {
            _repository = ContactRepositoryFactory.GetEmptyContactRepository;
            var contact = CommonMethods.GetFakeContact();
            _repository.Create(contact);
            Assert.AreEqual(1, _repository.GetAllEntities().Count);
            _repository.Dispose();
        }

        [TestMethod]
        public void TestGetById()
        {
            _repository = ContactRepositoryFactory.GetEmptyContactRepository;
            var contact = CommonMethods.GetFakeContact();
            _repository.Create(contact);
            Contact contactReturn;
            Assert.IsTrue(_repository.Get(0, out contactReturn));
            Assert.AreEqual(contact.Address, contactReturn.Address);
            Assert.AreEqual(contact.BirthDate, contactReturn.BirthDate);
            Assert.AreEqual(contact.Company, contactReturn.Company);
            Assert.AreEqual(contact.Email, contactReturn.Email);
            Assert.AreEqual(contact.Name, contactReturn.Name);
            Assert.AreEqual(contact.PersonalPhone, contactReturn.PersonalPhone);
            _repository.Dispose();
        }
    }
}
