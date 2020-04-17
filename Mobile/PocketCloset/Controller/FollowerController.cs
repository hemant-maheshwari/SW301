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

        public ObservableCollection<FollowViewModel> Followers  { get; set; }
        public ObservableCollection<FollowViewModel> Following { get; set; }

        public FollowerController()
        {
            restAPIService = new RestAPIService();
        }
        public async Task<ObservableCollection<FollowViewModel>> getAllFollowers(int userId)
        {
            var followers = await restAPIService.getAllFollowersAsync(userId);
            Followers = new ObservableCollection<FollowViewModel>(followers);
            return Followers;
        }
        public async Task<ObservableCollection<FollowViewModel>> getAllFollowing(int userId)
        {
            var following = await restAPIService.getAllFollowingAsync(userId);
            Following = new ObservableCollection<FollowViewModel>(following);
            return Following;
        }

    }
}

