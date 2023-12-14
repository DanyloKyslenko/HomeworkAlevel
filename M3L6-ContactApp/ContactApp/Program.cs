
namespace ContactApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var mutex = new Mutex(true, "ContactAppMutex");
            ContactManager contactManager = new ContactManager("contacts.txt");
            while (true)
            {
                if (mutex.WaitOne(0, false))
                {
                    try
                    {
                        Console.WriteLine("Выберите действие: \nadd-добавить контакт \ndelete-удалить контакт \nall-показать все контакты  \nsearch-поиск по номеру телефона" +
                    "\nexit-выход из программы\n");
                        string command = Console.ReadLine();
                        switch (command)
                        {
                            case "add":
                                Console.WriteLine("Введите имя (не больше 50 символов):");
                                string name = Console.ReadLine();
                                Console.WriteLine("введите фамилию (не больше 50 символов):");
                                string surname = Console.ReadLine();
                                Console.WriteLine("Введите номер телефона (до 15 цифр):");
                                var phoneNumber = Console.ReadLine();     
                                contactManager.AddContact(name, surname, phoneNumber);
                                break;
                            case "delete":
                                Console.WriteLine("Введите номер телефона контакта который хотите удалить: ");
                                string numberToDelete = Console.ReadLine();
                                contactManager.DeleteContact(numberToDelete);
                                break;
                            case "all":
                                contactManager.ShowContactsByManager();
                                break;
                            case "search":
                                Console.WriteLine("Введите параметр для поиска:");
                                string searchParam = Console.ReadLine();
                                List<Contact> searchResults = contactManager.SearchContacts(searchParam);
                                foreach (Contact contact in searchResults)
                                {
                                    Console.WriteLine(contact.Name , contact.Surname , contact.PhoneNumber);
                                }
                                break;
                            case "exit":
                                mutex.ReleaseMutex();
                                return;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ошибка: " + ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        Console.WriteLine("Выберите действие: \nadd-добавить контакт \ndelete-удалить контакт \nall-показать все контакты  \nsearch-поиск по любому параметру" +
                    "\nexit-выход из программы\n");
                        string command = Console.ReadLine();
                        switch (command)
                        {
                            case "add":
                                Console.WriteLine("Команда Add доступна только из первой копии программы");
                                break;
                            case "delete":
                                Console.WriteLine("Команда Delete доступна только из первой копии программы");
                                break;
                            case "all":
                                contactManager.ShowContactsByManager();
                                break;
                            case "search":
                                Console.WriteLine("Введите параметр для поиска:");
                                string searchParam = Console.ReadLine();
                                List<Contact> searchResults = contactManager.SearchContacts(searchParam);
                                foreach (Contact contact in searchResults)
                                {
                                    Console.WriteLine(contact.Name, contact.Surname, contact.PhoneNumber);
                                }
                                break;
                            case "exit":
                                return;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ошибка: " + ex.Message);
                    }
                }
            }
        }
    }
}