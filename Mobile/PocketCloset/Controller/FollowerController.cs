using PocketCloset.Models;
using PocketCloset.Service;
using PocketCloset.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PocketCloset.Controller 
{
    public class FollowerController : BaseController<Follower>
    {
        public RestAPIService restAPIService;

        public List<FollowViewModel> Followers  { get; set; }

        public FollowerController()
        {
            restAPIService = new RestAPIService();
        }
        public async Task<List<FollowViewModel>> getAllFollowers(int userId)
        {
            Followers = await restAPIService.getAllFollowersAsync(userId);
            return Followers;
        }

        public async Task<List<FollowViewModel>> getAllFollowing(int userId) {
            return await restAPIService.getAllFollowingAsync(userId);
        }
    }
}

