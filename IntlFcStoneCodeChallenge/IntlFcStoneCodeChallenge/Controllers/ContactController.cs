using System.Collections.Generic;
using System.Web.Http;
using IntlFcStoneCodeChallenge.Data;
using IntlFcStoneCodeChallenge.Factory;
using IntlFcStoneCodeChallenge.Interfaces;
using IntlFcStoneCodeChallenge.Models;
using Microsoft.AspNetCore.Mvc;
using FromBodyAttribute = Microsoft.AspNetCore.Mvc.FromBodyAttribute;
using HttpDeleteAttribute = Microsoft.AspNetCore.Mvc.HttpDeleteAttribute;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using HttpPutAttribute = Microsoft.AspNetCore.Mvc.HttpPutAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace IntlFcStoneCodeChallenge.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        protected IContactRepository _repository = ContactRepositoryFactory.GetContactRespository;

        // POST api/contact/create/
        [HttpPost("{Contact}")]
        public void Create([FromBody] Contact contact)
        {
            _repository.Create(contact);
        }

        // PUT api/contact/Update
        [HttpPut("{Contact}")]
        public bool Update([FromBody] Contact contact)
        {
            return _repository.Update(contact.Id, contact);
        }

        // DELETE api/contact/Delete
        [HttpDelete("{Contact}")]
        public bool Delete([FromBody] Contact contact)
        {
            Contact outContact;
            return _repository.Delete(contact.Id, out outContact);
        }

        [HttpGet("{id}")]
        [Route("~/contact/(id)")]
        public Contact Get(int id)
        {
            Contact outContact;
            if (_repository.Get(id, out outContact))
                return outContact;
            return null;
        }

        [HttpGet]
        public Dictionary<int, Contact> GetAllContacts()
        {
            return _repository.GetAllEntities();
        }

        [HttpGet("{phone}")]
        [Route("~/contact/getPhone/(phone)")]
        public Contact GetByPhone(string phone)
        {
            Contact contact;
            _repository.GetByPhone(phone, out contact);
            return contact;
        }

        [HttpGet("{email}")]
        [Route("~/contact/getEmail/(email)")]
        public Contact GetByEmail(string email)
        {
            Contact contact;
            _repository.GetByEmail(email, out contact);
            return contact;
        }

        [HttpGet("{state}")]
        [Route("~/contact/getAllState/(state)")]
        public List<Contact> GetAllByState(string state)
        {
            List<Contact> contact;
            _repository.GetAllByState(state, out contact);
            return contact;
        }

        [HttpGet("{city}")]
        [Route("~/contact/getAllCity/(city)")]
        public List<Contact> GetAllByCity(string city)
        {
            List<Contact> contact;
            _repository.GetAllByCity(city, out contact);
            return contact;
        }
    }
}
