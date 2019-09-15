using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using IntlFcStoneCodeChallenge.Data;
using IntlFcStoneCodeChallenge.Models;
using Microsoft.AspNetCore.Mvc;
using FromBodyAttribute = Microsoft.AspNetCore.Mvc.FromBodyAttribute;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace IntlFcStoneCodeChallenge.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        protected ContactRepository _repository;

        // POST api/contact/[contact]
        [HttpPost]
        public Contact Create([FromBody] Contact contact)
        {
            return contact;
        }
    }
}
