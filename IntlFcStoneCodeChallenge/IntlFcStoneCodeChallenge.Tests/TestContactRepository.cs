using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntlFcStoneCodeChallenge;
using IntlFcStoneCodeChallenge.Interfaces;
using IntlFcStoneCodeChallenge.Factory;
using IntlFcStoneCodeChallenge.Models;
using Bogus;
using System;

namespace IntlFcStoneCodeChallenge.Tests
{
    [TestClass]
    public class UnitTest1
    {
        IContactRepository _repository;

        private Contact GetFakeContact()
        {
            var id = 0;
            var oldDate = new DateTime(1950, 1, 1, 1, 1, 1, 1);
            var newDate = new DateTime(2001, 1, 1, 1, 1, 1, 1);
            return new Faker<Contact>()
                .StrictMode(true)
                .RuleFor(c => c.Address, f => f.Address.FullAddress())
                .RuleFor(c => c.BirthDate, f => f.Date.Between(oldDate, newDate).ToString())
                .RuleFor(c => c.Company, f => f.Company.CompanyName())
                .RuleFor(c => c.Email, f => f.Internet.Email())
                .RuleFor(c => c.Name, f => f.Name.FullName())
                .RuleFor(c => c.PersonalPhone, f => f.Phone.PhoneNumber())
                .RuleFor(c => c.WorkPhone, f => f.Phone.PhoneNumber())
                .RuleFor(c => c.ProfileImageFilename, f => f.Internet.Avatar())
                .RuleFor(c => c.Id, f => id++);
        }

        [TestMethod]
        public void TestGetAll()
        {
            _repository = ContactRepositoryFactory.GetFilledContactRespository;
            Assert.AreEqual(_repository.GetAllEntities().Count, 10);
        }

        [TestMethod]
        public void TestDelete()
        {
            _repository = ContactRepositoryFactory.GetFilledContactRespository;
            Contact contact;
            _repository.Delete(0, out contact);
            Assert.AreEqual(_repository.GetAllEntities().Count, 9);
        }

        [TestMethod]
        public void TestCreate()
        {
            _repository = ContactRepositoryFactory.GetEmptyContactRepository;
            var contact = GetFakeContact();
            _repository.Create(contact);
            Assert.AreEqual(_repository.GetAllEntities().Count, 1);
        }

        [TestMethod]
        public void TestGetById()
        {
            _repository = ContactRepositoryFactory.GetEmptyContactRepository;
            var contact = GetFakeContact();
            _repository.Create(contact);
            Contact contactReturn;
            Assert.IsTrue(_repository.Get(0, out contactReturn));
            Assert.AreEqual(contact.Address, contactReturn.Address);
            Assert.AreEqual(contact.BirthDate, contactReturn.BirthDate);
            Assert.AreEqual(contact.Company, contactReturn.Company);
            Assert.AreEqual(contact.Email, contactReturn.Email);
            Assert.AreEqual(contact.Name, contactReturn.Name);
            Assert.AreEqual(contact.PersonalPhone, contactReturn.PersonalPhone);
        }
    }
}
