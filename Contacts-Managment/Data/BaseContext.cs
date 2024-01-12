using Contacts_Managment.Models;
using Microsoft.EntityFrameworkCore;

namespace Contacts_Managment.Data
{
    public class BaseContext : DbContext
    {
        protected BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {
        }

        public DbSet<ContactModel> Contacts { get; set; }

    }
}
