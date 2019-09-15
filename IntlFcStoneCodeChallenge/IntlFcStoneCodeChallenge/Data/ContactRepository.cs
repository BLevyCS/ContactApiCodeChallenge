using IntlFcStoneCodeChallenge.Interfaces;
using IntlFcStoneCodeChallenge.Models;
using System.Linq;

namespace IntlFcStoneCodeChallenge.Data
{
    public class ContactRepository : BaseRepository<Contact>, IContactRepository
    {
        public bool GetByPhone(int phone, out Contact contact)
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
