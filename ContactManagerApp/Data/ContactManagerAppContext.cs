using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContactManager.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ContactManagerApp.Data
{
    public class ContactManagerAppContext : IdentityDbContext
    {
        public ContactManagerAppContext (DbContextOptions<ContactManagerAppContext> options)
            : base(options)
        {
        }

        public DbSet<ContactManager.Models.Contact> Contact { get; set; } = default!;
    }
}
