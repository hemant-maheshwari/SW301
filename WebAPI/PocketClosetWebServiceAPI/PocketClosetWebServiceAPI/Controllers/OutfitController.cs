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
    public class OutfitController : Controller, IOutfitController
    {
        private readonly IConfiguration config;
        public OutfitController(IConfiguration config) {
            this.config = config;
        }
        public JsonResult createOutfit(Outfit outfit)
        {
            throw new NotImplementedException();
        }

        public JsonResult deleteOutfit(int outfitId)
        {
            throw new NotImplementedException();
        }

        public JsonResult getAllOutfits(int userId)
        {
            throw new NotImplementedException();
        }

        public JsonResult getOutfit(int outfitId)
        {
            throw new NotImplementedException();
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult updateOutfit(Outfit outfit)
        {
            throw new NotImplementedException();
        }
    }
}