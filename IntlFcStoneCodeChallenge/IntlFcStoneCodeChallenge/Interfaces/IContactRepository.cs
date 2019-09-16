using IntlFcStoneCodeChallenge.Models;
using System;

namespace IntlFcStoneCodeChallenge.Interfaces
{
    interface IContactRepository : IBaseRepository<Contact>
    {
        bool GetByPhone(UInt64 phone, out Contact contact);
        bool GetByEmail(string email, out Contact contact);
    }
}
