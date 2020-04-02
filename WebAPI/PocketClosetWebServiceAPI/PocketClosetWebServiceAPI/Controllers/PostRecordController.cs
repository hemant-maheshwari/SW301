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
    public class PostRecordController : Controller, IPostRecordController
    {
        private readonly IConfiguration config;
        public PostRecordController(IConfiguration config) {
            this.config = config;
        }
        public JsonResult createPostRecord(PostRecord postRecord)
        {
            throw new NotImplementedException();
        }

        public JsonResult deletePostRecord(int postRecordId)
        {
            throw new NotImplementedException();
        }

        public JsonResult getAllPostRecords(int userId)
        {
            throw new NotImplementedException();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}