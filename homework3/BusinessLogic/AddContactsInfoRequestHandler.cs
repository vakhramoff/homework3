using System;
using System.Threading.Tasks;
using homework3.Models;
using homework3.Services.Interfaces;

namespace homework3.BusinessLogic
{
    public class AddContactsInfoRequestHandler
    {
        private readonly IContactInfoService _contactInfoService;

        public AddContactsInfoRequestHandler(IContactInfoService contactInfoService)
        {
            _contactInfoService = contactInfoService;
        }

        public Task<Contact> Handle(Contact contact)
        {
            if (contact.Id == Guid.Empty)
            {
                throw new ArgumentException("Некорректный идентификатор пользователя", nameof(contact.Id));
            }

            return _contactInfoService.AppendContact(contact);
        }
    }
}