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
        public ContactsController(GetContactsInfoRequestHandler getUsersInfoRequestHandler)
        {
            _getUsersInfoRequestHandler = getUsersInfoRequestHandler;
        }

        [HttpGet("{id}")]
        public Task<Contact> GetContactInfo(Guid id)
        {
            return _getUsersInfoRequestHandler.Handle(id);
        }
    }
}