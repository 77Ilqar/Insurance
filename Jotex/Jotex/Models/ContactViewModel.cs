using Repository.Enums;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jotex.Models
{
    public class ContactViewModel
    {

        public string Fullname { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }


        public string Description { get; set; }

        public Subject Subject { get; set; }

    }
}
