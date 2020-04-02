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
    public class FollowerController : Controller, IFollowerController
    {
        private readonly IConfiguration config;

        public FollowerController(IConfiguration config) {
            this.config = config;
        }
        public JsonResult createFollower(Follower follower)
        {
            throw new NotImplementedException();
        }

        public JsonResult deleteFollower(int followId)
        {
            throw new NotImplementedException();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}