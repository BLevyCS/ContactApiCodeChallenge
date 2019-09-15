using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntlFcStoneCodeChallenge.Context;
using IntlFcStoneCodeChallenge.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntlFcStoneCodeChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {

        private readonly ApplicationDbContext _context;


        // GET api/values
        [HttpPost]
        public ActionResult<IEnumerable<string>> Create([FromBody] Contact contact)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            _context.Contacts.Add(contact);
            _context.SaveChanges();

            return contact;
        }
    }
}
