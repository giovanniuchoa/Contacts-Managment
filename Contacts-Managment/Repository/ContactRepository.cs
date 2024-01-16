using Contacts_Managment.Data;
using Contacts_Managment.Models;

namespace Contacts_Managment.Repository
{
    public class ContactRepository : IContactRepository
    {

        private readonly Context _context;

        public ContactRepository(Context context) 
        {
            _context = context;
        }

        public ContactModel Add(ContactModel contact) // Register on database
        {
            _context.Contact.Add(contact);
            _context.SaveChanges();
            return contact;
        }

        public List<ContactModel> GetAll()
        {
            return _context.Contact.ToList();
        }

    }
}
