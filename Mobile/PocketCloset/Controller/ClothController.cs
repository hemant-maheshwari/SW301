﻿using PocketCloset.Models;
using PocketCloset.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PocketCloset.Controller
{
    class ClothController: BaseController<Cloth>
    {
        private RestAPIService restAPIService;

        public ClothController()
        {
            restAPIService = new RestAPIService();
        }

        //public Task<Cloth> createCloth(Cloth cloth) {
        //    return await restAPIService.createCloth(cloth);
        //}

    }
}
