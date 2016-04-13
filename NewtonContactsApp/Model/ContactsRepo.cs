using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonContactsApp.Model
{
    public class ContactsRepo : IContactsRepository
    {
        public void Init()
        {

        }

        public int Create(Contact contact)
        {
            throw new NotImplementedException();
        }

        public void Delete(int index)
        {
            throw new NotImplementedException();
        }

        public Contact Get(int index)
        {
            throw new NotImplementedException();
        }

        public IList<Contact> GetAll()
        {
            IList<Contact> contacts = new List<Contact>();

            contacts.Add(
                new Contact
                {
                    Address = "vägen 1",
                    Name = "David Kihlstrand",
                    CareOf = "Björn kihlstrand",
                    City = "Göteborg",
                    AppData = "Image?",
                    Country = "Sweden",
                    EmailAddress = "spam@spammail.com",
                    Index = 0,
                    PhoneNumber = "070000000",
                    PostalCode = "45521"
                });
            contacts.Add(
                new Contact
                {
                    Address = "vägen 2",
                    Name = "Annica Kihlstrand",
                    CareOf = "Derp kihlstrand",
                    City = "Stockholm",
                    AppData = "Image?",
                    Country = "Norge",
                    EmailAddress = "spam@spammail.com",
                    Index = 0,
                    PhoneNumber = "123123123",
                    PostalCode = "11111"
                }); 
            return contacts;
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
