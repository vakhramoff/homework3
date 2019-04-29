using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using homework3.Models;

namespace homework3.Services.Interfaces
{
    public interface IContactInfoService
    {
        Task<Contact> GetById(Guid id);
        Task<Contact> AppendContact(Contact contact);
    }
}
