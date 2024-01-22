namespace Labolatorium_3___App.Models
{
    public class MemoryContactService : IContactService
    {
        private readonly Dictionary<int, Contact> _contacts = new Dictionary<int, Contact>()
        {
            {1, new Contact() {Id = 1, Name = "Adam", Email="adas@gmail.com", Phone="123123123", Priority=Priority.High} },
            {2, new Contact() {Id = 2, Name = "Ewa", Email="ewcia@gmail.com", Phone="123123321", Priority= Priority.Low} },
        };
        private int _id = 3;

        private readonly IDateTimeProvider _timeProvider;
        public MemoryContactService(IDateTimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public void Add(Contact contact)
        {
            contact.Id = _id++;
            _contacts[contact.Id] = contact;
        }

        public void DeleteById(Contact contact)
        {
            _contacts.Remove(contact.Id);
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
