﻿using PocketCloset.Models;
using PocketCloset.Service;
using PocketCloset.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PocketCloset.Controller
{
    class PostController: BaseController<Post>
    {
        private RestAPIService restAPIService;

        public PostController()
        {
            restAPIService = new RestAPIService();
        }

        public async Task<Post> createPost(Post post) {
            return await restAPIService.createPost(post);
        }

        public async Task<List<FeedViewModel>> getAllFeeds(int userId) {
            return await restAPIService.getFeeds(userId);
        }
        

    }
}
