using IntlFcStoneCodeChallenge.Models;
using System;

namespace IntlFcStoneCodeChallenge.Interfaces
{
    public interface IContactRepository : IBaseRepository<Contact>
    {
        bool GetByPhone(string phone, out Contact contact);
        bool GetByEmail(string email, out Contact contact);
    }
}
