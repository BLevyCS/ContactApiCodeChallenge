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
        public static IContactRepository GetFilledContactRespository => FilledContactRepository.Value;
        public static IContactRepository GetEmptyContactRepository => EmptyContactRepository.Value;

        private static IContactRepository BuildFilledContactRepository()
        {
            var contactGenerator = new MockContactGenerator();
            var contactRepository = new ContactRepository(contactGenerator.GetContacts(10).ToList());
            return contactRepository;
        }

        private static IContactRepository BuildEmptyContactRepository()
        {
            return new ContactRepository();
        }

        private static Lazy<IContactRepository> FilledContactRepository = new Lazy<IContactRepository>(BuildFilledContactRepository);
        private static Lazy<IContactRepository> EmptyContactRepository = new Lazy<IContactRepository>(BuildEmptyContactRepository);
    }
}
