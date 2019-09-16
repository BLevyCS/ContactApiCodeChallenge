using IntlFcStoneCodeChallenge.Data;
using IntlFcStoneCodeChallenge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntlFcStoneCodeChallenge.Factory
{
    public static class ContactRepositoryFactory
    {
        public static IContactRepository GetContactRespository => ContactRepository.Value;

        private static IContactRepository BuildContactRepository()
        {
            var contactGenerator = new MockContactGenerator();
            var contactRepository = new ContactRepository(contactGenerator.GetContacts(10).ToList());
            return contactRepository;
        }

        private static Lazy<IContactRepository> ContactRepository = new Lazy<IContactRepository>(BuildContactRepository);
    }
}
