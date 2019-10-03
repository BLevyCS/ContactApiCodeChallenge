using IntlFcStoneCodeChallenge.Models;
using System;
using System.Collections.Generic;

namespace IntlFcStoneCodeChallenge.Interfaces
{
    public interface IContactRepository : IBaseRepository<Contact>, IDisposable
    {
        bool GetByPhone(string phone, out Contact contact);
        bool GetByEmail(string email, out Contact contact);
        bool GetAllByState(string state, out List<Contact> contacts);
        bool GetAllByCity(string city, out List<Contact> contacts);
    }
}
