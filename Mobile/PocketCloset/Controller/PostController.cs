using PocketCloset.Models;
using PocketCloset.Service;
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

        //public Task<Post> createPost(Post post) {
        //    return await restAPIService.createPost(post);
        //}

    }
}
