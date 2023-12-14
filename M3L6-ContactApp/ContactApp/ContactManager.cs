using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp
{
    public class ContactManager
    {
        private ContactList contactList;
        public ContactManager(string fileName)
        {
            contactList = new ContactList(fileName);
        }

        public void AddContact(string name, string surname, string phoneNumber)
        {
            Contact contact = new Contact
            {
                Name = name,
                Surname = surname,
                PhoneNumber = phoneNumber
            };
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname))
            {
                throw new ContactManagerException("Имя или фамилия не могут быть пустыми\n");
            }
            else if (name.Length > 50 || surname.Length > 50)
            {
                throw new ContactManagerException("В условиях нашей программы имя или фамилия не могут быть больше 50 символов\n");
            }
            else if (phoneNumber == null || phoneNumber.Length > 15 || !phoneNumber.All(char.IsDigit))
            {
                throw new ContactManagerException("Номер телефона должен состоять из цифр и количество символов не должно превышать 15\n");
            }
            else
            {
                contactList.AddContact(contact);
                Console.WriteLine($"Контакт {name} {surname} {phoneNumber} успешно добавлен: ");
            }
        }
        public void ShowContactsByManager()
        {
            contactList.ShowContacts();
        }
        public void DeleteContact(string phoneNumber)
        {
            Contact contactToDelete = contactList.SearchContacts(phoneNumber).FirstOrDefault();
            if (contactToDelete != null)
            {
                contactList.DeleteContact(contactToDelete);
            }
            else
            {
                throw new ContactManagerException("Контакт с таким номером телефона не найден , попробуйте ещё раз\n");
            }
        }

        public List<Contact> SearchContacts(string searchParam)
        {
            List<Contact> searchResults = contactList.SearchContacts(searchParam);

            if (searchResults.Count == 0)
            {
                throw new ContactManagerException("Контакт не найден , попробуйте ещё раз\n");
            }
            else
            {
                return searchResults;
            }
        }
    }
}
