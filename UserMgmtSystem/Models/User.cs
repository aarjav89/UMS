using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserMgmtSystem.Models
{
    public class User
    {
        // here we will just specify the properties (Getters and setters) we want to use

        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public bool Status { get; set; }

        //now we will create context
    }
}
