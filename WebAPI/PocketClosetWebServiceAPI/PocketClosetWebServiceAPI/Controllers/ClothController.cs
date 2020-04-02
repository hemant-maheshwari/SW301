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
    public class ClothController : Controller, IClothController
    {
        private readonly IConfiguration config;
        public ClothController(IConfiguration config) {
            this.config = config;
        }
        public JsonResult createCloth(Cloth cloth)
        {
            throw new NotImplementedException();
        }

        public JsonResult getAllClothes(int userId)
        {
            throw new NotImplementedException();
        }

        public JsonResult getCloth(int clothId)
        {
            throw new NotImplementedException();
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult updateCloth(Cloth cloth)
        {
            throw new NotImplementedException();
        }
    }
}