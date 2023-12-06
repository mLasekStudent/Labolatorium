using Labolatorium_3___App.Models;
using Data;
using Data.Entities;

namespace Labolatorium_3___App.Mappers
{
    public class ContactMapper
    {
        public static Contact FromEntity(ContactEntity entity)
        {
            return new Contact()
            {
                Id = entity.ContactId,
                Name = entity.Name,
                Email = entity.Email,
                Phone = entity.Phone,
                Birth = entity.Birth,
            };
        }

        public static ContactEntity ToEntity(Contact model)
        {
            return new ContactEntity()
            {
                ContactId = model.Id,
                Name = model.Name,
                Email = model.Email,
                Phone = model.Phone,
                Birth = model.Birth,
            };
        }
    }
}
