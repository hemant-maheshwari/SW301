using PocketCloset.Models;
using PocketCloset.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PocketCloset.Controller
{
    public class UserController: BaseController<User> 
    {
        private RestAPIService restAPIService;

        public UserController()
        {
            restAPIService = new RestAPIService();
        }

        public async Task<bool> checkUsername(string username)
        {
            return await restAPIService.checkUsernameAsync(username);
        }

        public async Task<User> checkUser(User user)
        {
            return await restAPIService.checkUserAsync(user);
        }

        public async Task<User> getUserFromUsername(String username)
        {
            return await restAPIService.getUserFromUsernameAsync(username);
        }
    } 
}
