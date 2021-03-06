﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactApiCodeChallenge.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string ProfileImageFilename { get; set; }
        public string Email { get; set; }
        public string BirthDate { get; set; }
        public string WorkPhone { get; set; }
        public string PersonalPhone { get; set; }
        public string Address { get; set; }
    }
}
