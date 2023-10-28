namespace Labolatorium_3___App.Models
{
    public class MemoryContactService : IContactService
    {
        private readonly Dictionary<int, Contact> _contacts = new Dictionary<int, Contact>()
        {
            {1, new Contact() {Id = 1, Name = "Adam", Email="adas@gmail.com", Phone="123123123"} },
            {2, new Contact() {Id = 2, Name = "Ewa", Email="ewcia@gmail.com", Phone="123123321"} },
        };
        private int _id = 3;
        public void Add(Contact contact)
        {
            contact.Id = _id++;
            _contacts[contact.Id] = contact;
        }

        public void DeleteById(int id)
        {
            _contacts.Remove(id);
        }

        public List<Contact> FindAll()
        {
            return _contacts.Values.ToList();
        }

        public Contact? FindById(int id)
        {
            return _contacts[id];
        }

        public void Update(Contact contact)
        {
            _contacts[contact.Id] = contact;
        }
    }
}
