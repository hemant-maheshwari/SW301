using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PocketCloset.Models;

namespace PocketClosetWebServiceAPI.Controllers
{
    [Route("v1/api/[controller]")]
    public class AccountController : Controller, IAccountController
    {
        private readonly IConfiguration config;

        public AccountController(IConfiguration config) {
            this.config = config;
        }
        public JsonResult createAccount(Account account)
        {
            throw new NotImplementedException();
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult updateAccount(Account account)
        {
            throw new NotImplementedException();
        }
    }
}