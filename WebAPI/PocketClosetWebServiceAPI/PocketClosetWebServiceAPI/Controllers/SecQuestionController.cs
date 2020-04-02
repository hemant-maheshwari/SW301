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
    public class SecQuestionController : Controller, ISecQuestionController
    {
        private readonly IConfiguration config;
        public SecQuestionController(IConfiguration config) {
            this.config = config;
        }
        public JsonResult createSecQuestion(SecQuestion secQuestion)
        {
            throw new NotImplementedException();
        }

        public JsonResult getSecQuestion(int userId)
        {
            throw new NotImplementedException();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}