﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using homework3.Models;

namespace homework3.Services.Interfaces
{
    public interface IUserInfoService
    {
        Task<Contact> GetById(Guid id);
    }
}
