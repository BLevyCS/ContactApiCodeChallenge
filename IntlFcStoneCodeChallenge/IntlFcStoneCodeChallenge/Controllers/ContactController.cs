using System.Collections.Generic;
using System.Web.Http;
using IntlFcStoneCodeChallenge.Data;
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
        protected ContactRepository _repository;

        // POST api/contact/
        [HttpPost("{Contact}")]
        public void Create([FromBody] Contact contact)
        {
            _repository.Create(contact);
        }

        // PUT api/contact/{Contact}
        [HttpPut("{Contact}")]
        public bool Update([FromBody] Contact contact)
        {
            return _repository.Update(contact.Id, contact);
        }

        // DELETE api/contact/{Contact}
        [HttpDelete("{Contact}")]
        public bool Delete([FromBody] Contact contact)
        {
            Contact outContact;
            return _repository.Delete(contact.Id, out outContact);
        }

        [HttpGet("{id}")]
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

    }
}
