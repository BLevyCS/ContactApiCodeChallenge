using Bogus;
using IntlFcStoneCodeChallenge.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntlFcStoneCodeChallenge.Tests
{
    public class CommonMethods
    {
        public static Contact GetFakeContact()
        {
            var id = 0;
            var oldDate = new DateTime(1950, 1, 1, 1, 1, 1, 1);
            var newDate = new DateTime(2001, 1, 1, 1, 1, 1, 1);
            return new Faker<Contact>()
                .StrictMode(true)
                .RuleFor(c => c.Address, f => f.Address.FullAddress())
                .RuleFor(c => c.BirthDate, f => f.Date.Between(oldDate, newDate).ToString())
                .RuleFor(c => c.Company, f => f.Company.CompanyName())
                .RuleFor(c => c.Email, f => f.Internet.Email())
                .RuleFor(c => c.Name, f => f.Name.FullName())
                .RuleFor(c => c.PersonalPhone, f => f.Phone.PhoneNumber())
                .RuleFor(c => c.WorkPhone, f => f.Phone.PhoneNumber())
                .RuleFor(c => c.ProfileImageFilename, f => f.Internet.Avatar())
                .RuleFor(c => c.Id, f => id++);
        }
    }
}
