using Newtonsoft.Json;
using PocketCloset.Models;
using PocketCloset.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PocketCloset.Service
{
    public class RestAPIService : WebAPIConfiguration
    {

        private async Task<Response> getHTTPResponse(HttpResponseMessage response)
        {
            string result = await response.Content.ReadAsStringAsync();
            Response responseObject = JsonConvert.DeserializeObject<Response>(result);
            return responseObject;
        }

        private User getUserFromResponse(Response response)
        {
            string userString = response.data;
            User user = JsonConvert.DeserializeObject<User>(userString);
            return user;
        }


        public async Task<bool> checkUsernameAsync(string username)
        {
            string url = WEB_API_BASE_URL + "user/check/" + username;
            HttpResponseMessage response = await httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                Response responseObject = await getHTTPResponse(response);
                return responseObject.status;
            }
            else
            {
                Debug.WriteLine("Error Occured!");
                return false;
            }
        }

    }
}
