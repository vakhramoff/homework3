using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using homework3.BusinessLogic;
using homework3.Models;

namespace homework3.Controllers
{
    [Route("api/users")]
    public class ContactsController : ControllerBase
    {
        private readonly GetContactsInfoRequestHandler _getUsersInfoRequestHandler;
        private readonly AddContactsInfoRequestHandler _addUsersInfoRequestHandler;
        public ContactsController(GetContactsInfoRequestHandler getUsersInfoRequestHandler, AddContactsInfoRequestHandler addUsersInfoRequestHandler)
        {
            this._getUsersInfoRequestHandler = getUsersInfoRequestHandler;
            this._addUsersInfoRequestHandler = addUsersInfoRequestHandler;
        }

        [HttpGet("{id}")]
        public Task<Contact> GetContactInfo(Guid id)
        {
            return _getUsersInfoRequestHandler.Handle(id);
        }

        [HttpPost("append")]
        public Task<Contact> AppendContact([FromBody] Contact contact)
        {
            Guid guid = Guid.NewGuid();
            contact.Id = guid;
            return _addUsersInfoRequestHandler.Handle(contact);
        }


    }
}