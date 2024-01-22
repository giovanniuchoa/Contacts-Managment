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

        public ContactModel Edit(ContactModel contact)
        {
            ContactModel contactDB = ListById(contact.Id);

            if (contactDB == null) throw new Exception("There was an error during contact update.");

            contactDB.Name = contact.Name;
            contactDB.Email = contact.Email;
            contactDB.Number = contact.Number;

            _context.Contact.Update(contactDB);
            _context.SaveChanges();

            return contactDB;

        }

        public List<ContactModel> GetAll()
        {
            return _context.Contact.ToList();
        }

        public ContactModel ListById(int id)
        {
            return _context.Contact.FirstOrDefault(x => x.Id == id);
        }

    }
}
