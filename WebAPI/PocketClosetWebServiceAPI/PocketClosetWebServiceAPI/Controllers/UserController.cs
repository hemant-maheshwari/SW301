using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PocketCloset.Models;
using PocketClosetWebServiceAPI.Models;

namespace PocketClosetWebServiceAPI.Controllers
{
    [Route("v1/api/[controller]")]
    public class UserController : Controller, IUserController
    {
        private readonly IConfiguration config;

        public UserController(IConfiguration config) {
            this.config = config;
        }

        public JsonResult createUser(User user)
        {
            throw new NotImplementedException();
        }

        public JsonResult getUser(int userId)
        {
            throw new NotImplementedException();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("testGet")]
        public JsonResult testGet() {
            Response response = new Response();
            response.message = "success!!!";
            return Json(response);
        }

        public JsonResult updateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}