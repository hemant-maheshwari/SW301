using PocketCloset.Models;
using PocketCloset.Service;
using PocketCloset.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace PocketCloset.Controller 
{
    public class FollowerController : BaseController<FollowViewModel>
    {
        public RestAPIService restAPIService;

        //public ObservableCollection<FollowViewModel> Followers  { get; set; }
        //public ObservableCollection<FollowViewModel> Following { get; set; }

        public FollowerController()
        {
            restAPIService = new RestAPIService();
        }
        public async Task<List<FollowViewModel>> getAllFollowers(int userId)
        {
            return await restAPIService.getAllFollowersAsync(userId);            
        }
        public async Task<List<FollowViewModel>> getAllFollowing(int userId)
        {
            return await restAPIService.getAllFollowingAsync(userId);            
        }

    }
}

