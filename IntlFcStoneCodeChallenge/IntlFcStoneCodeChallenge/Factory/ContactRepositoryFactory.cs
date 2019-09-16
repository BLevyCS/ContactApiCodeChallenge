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
            return new ContactRepository();
        }

        private static Lazy<IContactRepository> ContactRepository = new Lazy<IContactRepository>(BuildContactRepository);
    }
}
