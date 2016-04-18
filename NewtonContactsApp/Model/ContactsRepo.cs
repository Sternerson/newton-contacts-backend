using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace NewtonContactsApp.Model
{
    public class ContactsRepo : IContactsRepository
    {
        private StorageFile file = null;
        private List<Contact> contacts;
        public bool IsInitialized { get { return null != file; } }

        public ContactsRepo()
        {
            contacts = new List<Contact>();
        }

        public async Task InitializeAsync()
        {
            if (!IsInitialized)
            {
                await Initialize("contacts.xml");
            }
        }

        private async Task Initialize(string filename)
        {
            DataContractSerializer serializer = new DataContractSerializer(typeof(List<Contact>));
            file = await ApplicationData.Current.LocalFolder.CreateFileAsync(filename, CreationCollisionOption.OpenIfExists);
            using (var stream = await file.OpenReadAsync())
            {
                serializer.ReadObject(stream.GetInputStreamAt(0).
            }
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
            throw new NotImplementedException();
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
