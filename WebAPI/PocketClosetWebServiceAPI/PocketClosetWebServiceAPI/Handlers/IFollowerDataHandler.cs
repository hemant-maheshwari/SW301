using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PocketClosetWebServiceAPI.Handlers
{
    public interface IFollowerDataHandler
    {
        bool createFollower();
        bool deleteFollower(int followId);
    }
}
