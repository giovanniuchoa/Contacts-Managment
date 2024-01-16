using Contacts_Managment.Models;

namespace Contacts_Managment.Repository
{
    public interface IContactRepository
    {
        List<ContactModel> GetAll();
        ContactModel Add(ContactModel contact);
    }
}
