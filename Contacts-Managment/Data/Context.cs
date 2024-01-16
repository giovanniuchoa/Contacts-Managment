using Contacts_Managment.Models;
using Microsoft.EntityFrameworkCore;

namespace Contacts_Managment.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<ContactModel> Contact { get; set; }

    }
}
