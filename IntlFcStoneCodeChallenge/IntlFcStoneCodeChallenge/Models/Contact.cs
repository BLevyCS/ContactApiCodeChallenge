using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntlFcStoneCodeChallenge.Models
{
    public class Contact
    {
        public long Id { get; }
        public string Name { get; private set; }
        public string Company { get; private set; }
        public string ProfileImageFilename { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public int WorkPhone { get; private set; }
        public int PersonalPhone { get; private set; }
        public string Address { get; private set; }
    }
}
