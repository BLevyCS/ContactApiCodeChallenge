using IntlFcStoneCodeChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntlFcStoneCodeChallenge.Interfaces
{
    interface IContactRepository : IBaseRepository<Contact>
    {
        bool GetByPhone(int phone, out Contact contact);
        bool GetByEmail(string email, out Contact contact);
    }
}
