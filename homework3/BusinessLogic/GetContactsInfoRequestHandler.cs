using System;
using System.Threading.Tasks;
using homework3.Models;
using homework3.Services.Interfaces;

namespace homework3.BusinessLogic
{
    public class GetContactsInfoRequestHandler
    {
        private readonly IContactInfoService _userInfoService;

        public GetContactsInfoRequestHandler(IContactInfoService userInfoService)
        {
            _userInfoService = userInfoService;
        }

        public Task<Contact> Handle(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException("Некорректный идентификатор пользователя", nameof(id));
            }
            return _userInfoService.GetById(id);
        }
    }
}