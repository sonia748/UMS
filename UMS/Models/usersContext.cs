using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UMS.Models
{
    public class usersContext: DbContext
    {
        public usersContext(DbContextOptions<usersContext>option) : base(option)
        {

        }
        public DbSet<users> users { get; set; }
    }
}
