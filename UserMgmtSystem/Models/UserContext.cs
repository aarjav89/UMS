using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserMgmtSystem.Models
{
    public class UserContext : DbContext 
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options) // this is a constructor which takes parameter of DbContext Class which is parsed as UserContext. this will provide a secure session between database and model.
        {

        }

        public DbSet<User> user { get; set; }
    }
}
