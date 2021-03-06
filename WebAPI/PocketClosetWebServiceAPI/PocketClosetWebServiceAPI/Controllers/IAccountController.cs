﻿using Microsoft.AspNetCore.Mvc;
using PocketCloset.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PocketClosetWebServiceAPI.Controllers
{
    public interface IAccountController
    {
        JsonResult createAccount(Account account);
        JsonResult updateAccount(Account account);
        //JsonResult getAccount(Account account);
    }
}
