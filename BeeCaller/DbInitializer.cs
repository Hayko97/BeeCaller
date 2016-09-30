using BeeCaller.Helpers;
using BeeCaller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeCaller
{
    static class DbInitializer
    {
        private static DatabaseHelper dbHelper = new DatabaseHelper();

        static DbInitializer()
        {
            Initialize();
        }
        private static void Initialize()
        {
                
            List<Contacts> contacts = new List<Contacts>
            {
                new Contacts
                {
                    Name = "Garegin",
                    PhoneNumber = "1111111"
                },
                new Contacts
                {
                    Name = "Hayk",
                    PhoneNumber = "2222222"
                },
                new Contacts
                {
                    Name = "Vache",
                    PhoneNumber = "333333"
                }
            };
            var allContacts = dbHelper.ReadContacts();
            if (allContacts.Count == 0)
            {
                foreach (var item in contacts)
                {
                    dbHelper.Insert(item);
                }
            }
           
           
        }

        public static void Init() { }
    }
}
