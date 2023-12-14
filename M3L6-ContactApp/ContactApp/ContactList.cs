using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp
{
        public class ContactList
        {
            private List<Contact> contacts;
            private string fileName;

            public ContactList(string fileName)
            {
                this.contacts = new List<Contact>();
                this.fileName = fileName;
                LoadContactsFromFile();
            }

            private void LoadContactsFromFile()
            {
                if (File.Exists(fileName))
                {
                    string[] lines = File.ReadAllLines(fileName);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(';');
                        Contact contact = new Contact
                        {
                            Name = parts[0],
                            Surname = parts[1],
                            PhoneNumber = parts[2]
                        };
                        contacts.Add(contact);
                    }
                }
            }

            public void AddContact(Contact contact)
            {
            if (!contacts.Any(c => c.PhoneNumber == contact.PhoneNumber))
            {
                contacts.Add(contact);
                SaveContactsToFileAsync();
            }
            else 
            {
                Console.WriteLine("Контакт с таким номером телефона уже существует\n");
            }
            }

            public void DeleteContact(Contact contact)
            {
                Contact contactToDelete = contact;
                contacts.Remove(contactToDelete);
                Console.WriteLine($"Контакт {contact.Name} {contact.Surname}успешно удалён\n");
                SaveContactsToFileAsync();
            }
            public void ShowContacts()
            {
                Console.WriteLine("Список контактов:");
                foreach (Contact contact in contacts)
                {
                    Console.WriteLine($"Имя: {contact.Name}, Фамилия: {contact.Surname}, Телефон: {contact.PhoneNumber}");
                }
            }

            public List<Contact> SearchContacts(string searchParam)
            {
                return contacts.Where(c => c.Name.Contains(searchParam) || c.Surname.Contains(searchParam) || c.PhoneNumber.Contains(searchParam)).ToList();
            }
            private async Task SaveContactsToFileAsync()
            {
                string[] lines = contacts.Select(c => $"{c.Name};{c.Surname};{c.PhoneNumber}").ToArray();
                await File.WriteAllLinesAsync(fileName, lines);
            }
        }   
}
