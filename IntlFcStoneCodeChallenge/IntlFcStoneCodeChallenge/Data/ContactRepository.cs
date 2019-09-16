using IntlFcStoneCodeChallenge.Interfaces;
using IntlFcStoneCodeChallenge.Models;
using System;
using System.Linq;

namespace IntlFcStoneCodeChallenge.Data
{
    public class ContactRepository : BaseRepository<Contact>, IContactRepository
    {
        public override bool Create(Contact contact)
        {
            contact.Id = lastId;
            _entities.Add(lastId, contact);
            lastId++;
            return true;
        }

        public bool GetByPhone(UInt64 phone, out Contact contact)
        {
            contact = _entities.Values.FirstOrDefault(x => x.PersonalPhone == phone || x.WorkPhone == phone);
            return contact != null;
        }

        public bool GetByEmail(string email, out Contact contact)
        {
            contact = _entities.Values.FirstOrDefault(x => x.Email.Equals(email));
            return contact != null;
        }
    }
}
