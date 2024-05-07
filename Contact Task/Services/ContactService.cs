using Contact_Task.Data;

namespace Contact_Task.Services
{
    public class ContactService
    {
        private List<Contact> _contacts = new();

        public List<Contact> GetAllContacts()
        {
            
            return _contacts;

        }

        public void AddContact(Contact contact)
        {
            contact.Id = _contacts.Any() ? _contacts.Max(x => x.Id) + 1 : 1;
            _contacts.Add(contact);
        }

        public Contact GetContact(int id) => _contacts.FirstOrDefault(c => c.Id == id);

        public void UpdateContact(Contact contact)
        {
            var index = _contacts.FindIndex(c => c.Id == contact.Id);
            if (index != -1)
            {
                _contacts[index] = contact;
            }
        }

        public void DeleteContact(int id)
        {
            var contact = _contacts.FirstOrDefault(c => c.Id == id);
            if (contact != null)
            {
                _contacts.Remove(contact);
            }
        }


    }
}
