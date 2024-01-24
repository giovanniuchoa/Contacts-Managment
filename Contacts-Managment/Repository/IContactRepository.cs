using Contacts_Managment.Models;

namespace Contacts_Managment.Repository
{
    public interface IContactRepository
    {
        ContactModel Add(ContactModel contact);
        ContactModel Edit(ContactModel contact);
        List<ContactModel> GetAll();
        ContactModel ListById(int id);
        bool Delete(int id);
    }
}
