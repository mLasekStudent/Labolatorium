using Data.Entities;
using Data;
using Labolatorium_3___App.Mappers;

namespace Labolatorium_3___App.Models
{
    public class EFContactService : IContactService
    {
        private AppDbContext _context;

        public EFContactService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Contact contact)
        {
            var e = _context.Contacts.Add(ContactMapper.ToEntity(contact));
            _context.SaveChanges();
           /* return e.Entity.ContactId; */
        }
        
        public void DeleteById(Contact contact)
        {
            ContactEntity? find = _context.Contacts.Find(contact.Id);
            if (find != null)
            {
                _context.Contacts.Remove(find);
            }
        }

        public List<Contact> FindAll()
        {
            return _context.Contacts.Select(e => ContactMapper.FromEntity(e)).ToList(); ;
        }

        public Contact? FindById(int id)
        {
            return ContactMapper.FromEntity(_context.Contacts.Find(id));
        }

        public void Update(Contact contact)
        {
            _context.Contacts.Update(ContactMapper.ToEntity(contact));
        }
    }
}
