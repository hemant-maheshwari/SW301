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
    public class PostController : Controller, IPostController
    {
        private readonly IConfiguration config;
        public PostController(IConfiguration config) {
            this.config = config;
        }
        public JsonResult createPost(Post post)
        {
            throw new NotImplementedException();
        }

        public JsonResult getAllPosts(int userId)
        {
            throw new NotImplementedException();
        }

        public JsonResult getPost(int postId)
        {
            throw new NotImplementedException();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}