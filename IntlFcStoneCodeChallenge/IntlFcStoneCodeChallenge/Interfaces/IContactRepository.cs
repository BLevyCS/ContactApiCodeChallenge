using IntlFcStoneCodeChallenge.Models;

namespace IntlFcStoneCodeChallenge.Interfaces
{
    interface IContactRepository : IBaseRepository<Contact>
    {
        bool GetByPhone(int phone, out Contact contact);
        bool GetByEmail(string email, out Contact contact);
    }
}
