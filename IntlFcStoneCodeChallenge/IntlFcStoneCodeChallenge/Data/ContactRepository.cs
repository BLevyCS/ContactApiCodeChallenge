using IntlFcStoneCodeChallenge.Interfaces;
using IntlFcStoneCodeChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IntlFcStoneCodeChallenge.Data
{
    public class ContactRepository : BaseRepository<Contact>, IContactRepository
    {
        public ContactRepository(List<Contact> startingContacts)
        {
            for (int i = 0; i < startingContacts.Count; i++)
            {
                _entities.Add(i, startingContacts[i]);
            }
            lastId = startingContacts.Count() + 1;
        }

        public override bool Create(Contact contact)
        {
            contact.Id = lastId;
            _entities.Add(lastId, contact);
            lastId++;
            return true;
        }

        public bool GetByPhone(string phone, out Contact contact)
        {
            contact = _entities.Values.FirstOrDefault(x => x.PersonalPhone.Equals(phone) || x.WorkPhone.Equals(phone));
            return contact != null;
        }

        public bool GetByEmail(string email, out Contact contact)
        {
            contact = _entities.Values.FirstOrDefault(x => x.Email.Equals(email));
            return contact != null;
        }

        public bool GetAllByState(string state, out List<Contact> contacts)
        {
            contacts = new List<Contact>();
            contacts.AddRange(_entities.Values.Where(e => e.Address.Contains(state)));
            return contacts.Count > 0;
        }

        public bool GetAllByCity(string city, out List<Contact> contacts)
        {
            contacts = new List<Contact>();
            contacts.AddRange(_entities.Values.Where(e => e.Address.Contains(city)));
            return contacts.Count > 0;
        }
    }
}
