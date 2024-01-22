using Contacts_Managment.Models;
using Contacts_Managment.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Contacts_Managment.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactRepository _contactRepository;
        public ContactController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public IActionResult Index()
        {
            List<ContactModel> contacts = _contactRepository.GetAll();
            return View(contacts);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {

            ContactModel contact = _contactRepository.ListById(id);

            return View(contact);
        }

        public IActionResult DeleteConfirm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(ContactModel contact) 
        {
            if(ModelState.IsValid) 
            {
                _contactRepository.Edit(contact);
                return RedirectToAction("Index");
            }

            return View(contact);

        }

        [HttpPost]
        public IActionResult Create(ContactModel contact)
        {
            if (ModelState.IsValid)
            {
                _contactRepository.Add(contact);
                return RedirectToAction("Index");
            }

            return View(contact);

        }
    }
}
