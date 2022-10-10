using AulaEF_CodeFirst.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaEF_CodeFirst.Context
{
    internal class PersonContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
    }
}
